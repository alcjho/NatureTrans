using NatureTrans.Auth;
using NatureTrans.Data;
using NatureTrans.Migrations;
using NatureTrans.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NatureTrans
{
    internal partial class NewCommand : Form
    {
        private readonly OrderService _order;
        private readonly InventoryService _inventory;
        private PurchaseOrder _purchaseOrder;
        private readonly InventoryForm _inventoryForm;
        public bool edit = false;
        public int orderId;

        public NewCommand(OrderService order, InventoryService inventory, InventoryForm inventoryForm)
        {
            InitializeComponent();
            _order = order;
            _inventory = inventory;
            _inventoryForm = inventoryForm;
            _purchaseOrder = new PurchaseOrder();
            bindControls();
        }

        public async void UpdatePurchaseData(PurchaseOrder purchaseOrder)
        {
            _purchaseOrder = purchaseOrder;
            bindControls();
        }

        public void bindControls()
        {
            order_article_cmb.DataBindings.Clear();
            order_provider_cmb.DataBindings.Clear();
            order_quantity_txt.DataBindings.Clear();
            order_price_txt.DataBindings.Clear();
            order_comment_txt.DataBindings.Clear();
            order_received_chk.DataBindings.Clear();

            order_article_cmb.DataBindings.Add("SelectedValue", _purchaseOrder, "productId", true, DataSourceUpdateMode.OnPropertyChanged);
            order_provider_cmb.DataBindings.Add("SelectedValue", _purchaseOrder, "providerId", true, DataSourceUpdateMode.OnPropertyChanged); ;
            order_quantity_txt.DataBindings.Add("Text", _purchaseOrder, "quantity", true, DataSourceUpdateMode.OnPropertyChanged);
            order_price_txt.DataBindings.Add("Text", _purchaseOrder, "price", true, DataSourceUpdateMode.OnPropertyChanged);
            order_comment_txt.DataBindings.Add("Text", _purchaseOrder, "comment", true, DataSourceUpdateMode.OnPropertyChanged);
            order_received_chk.DataBindings.Add("Checked", _purchaseOrder, "received", true, DataSourceUpdateMode.OnPropertyChanged);

            if (edit)
            {
                string productName = _order.GetProductNameById(_purchaseOrder.productId);
                string providerName = _order.GetProviderNameById(_purchaseOrder.providerId);
                UpdateProductCombo(productName);
                UpdateProviderCombo(providerName);
            }
        }

        private void UpdateProductCombo(string searchText)
        {
            var filteredProducts = new List<Product>();
            var allProducts = _inventory.GetProductList(0, 100);

            if (!string.IsNullOrEmpty(searchText))
            {
                filteredProducts = _inventory.FilterProducts(searchText);

                // Move filtered products to the top, maintaining order for non-matching products
                allProducts = filteredProducts
                    .Concat(allProducts.Except(filteredProducts))
                    .ToList();
            }

            // Your filtering and updating logic here
            order_article_cmb.DataSource = allProducts;
            order_article_cmb.DisplayMember = "name";
            order_article_cmb.ValueMember = "id";

        }

        private void UpdateProviderCombo(string searchText)
        {
            var filteredProviders = new List<Provider>();
            var allProviders = _order.GetProviderList(0, 100);


            if (!string.IsNullOrEmpty(searchText))
            {
                filteredProviders = _order.FilterProvider(searchText);

                // Move filtered provider to the top, maintaining order for non-matching products
                allProviders = filteredProviders
                    .Concat(allProviders.Except(filteredProviders))
                    .ToList();
            }

            // Your filtering and updating logic here
            order_provider_cmb.DataSource = allProviders;
            order_provider_cmb.DisplayMember = "name";
            order_provider_cmb.ValueMember = "id";
        }

        private void NewCommand_Load(object sender, EventArgs e)
        {
            _purchaseOrder.userId = Session.UserId;

            if (edit)
            {
                order_add_btn.Text = $"Modifier PO {_purchaseOrder.id}";
                order_remove_btn.Visible = true;

                if (_purchaseOrder.received)
                {
                    order_price_txt.ReadOnly = true;
                    order_quantity_txt.ReadOnly = true;
                    order_received_chk.Enabled = false;
                }
                else
                {
                    order_price_txt.ReadOnly = false;
                    order_quantity_txt.ReadOnly = false;
                    order_received_chk.Enabled = true;
                }
            }
            else
            {
                order_price_txt.ReadOnly = false;
                order_quantity_txt.ReadOnly = false;
                order_received_chk.Enabled = true;

                order_add_btn.Text = $"Ajouter PO";
                order_remove_btn.Visible = false;
            }
        }

        private void order_article_cmb_TextChanged(object sender, EventArgs e)
        {

        }

        private void order_provider_cmb_TextChanged(object sender, EventArgs e)
        {

        }

        private void order_provider_cmb_TextUpdate(object sender, EventArgs e)
        {
            string searchString = order_provider_cmb.Text;
            if (searchString.Length >= 3)
            {
                if (order_provider_cmb.SelectedItem == null)
                {
                    order_provider_cmb.DroppedDown = true;
                }
                UpdateProviderCombo(searchString);
                order_provider_cmb.SelectionStart = order_provider_cmb.Text.Length;
                order_provider_cmb.SelectionLength = 0;
            }
        }

        private void order_article_cmb_TextUpdate(object sender, EventArgs e)
        {
            string searchString = order_article_cmb.Text;
            if (searchString.Length >= 3)
            {
                if (order_article_cmb.SelectedItem == null)
                {
                    order_article_cmb.DroppedDown = true;
                }
                UpdateProductCombo(searchString);
                order_article_cmb.SelectionStart = order_article_cmb.Text.Length;
                order_article_cmb.SelectionLength = 0;
            }
        }

        private async void order_add_btn_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                var result = await _order.AddPurchaseOrder(_purchaseOrder);

                if (result != null && result.id > 0)
                {

                    if(_purchaseOrder.received)
                        _inventory.UpdateInventory(_purchaseOrder);

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Manque d'infos pour l'ajout d'une commande", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (_purchaseOrder != null)
                {
                    var result = await _order.UpdatePurchaseOrder(_purchaseOrder);
                    if (result == 1)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show($"La mise-à-jour du PO {_purchaseOrder.id} a échouée", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show($"PO invalide, manque d'infos obligatoires", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        private void order_remove_btn_Click(object sender, EventArgs e)
        {
            if (_purchaseOrder != null)
            {
                DialogResult result = MessageBox.Show($"Etes-vous sur de supprimer le PO {_purchaseOrder.id} ? cette action affecte aussi l'inventaire", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    bool deleted = _order.RemovePO(_purchaseOrder.id);
                    if (deleted)
                    {
                        if (_purchaseOrder.received)
                        {
                            _inventory.RemoveFromInventory(_purchaseOrder);
                        }

                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        this.DialogResult = DialogResult.Cancel;
                    }
                }
            }
            else
            {
                MessageBox.Show($"PO invalide, manque d'infos obligatoires", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
