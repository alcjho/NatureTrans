using Microsoft.EntityFrameworkCore.Storage.Json;
using Microsoft.Identity.Client;
using NatureTrans.Auth;
using NatureTrans.Data;
using NatureTrans.Service;
using NatureTrans.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NatureTrans
{
    internal partial class orderForm : Form
    {
        private readonly OrderService _order;
        private readonly InventoryService _inventory;
        private PurchaseOrder _purchaseOrder;
        private readonly NewCommand _newCommandForm;
        private bool isItemSelected = false;
        private bool edit = false;


        public orderForm(OrderService order, InventoryService inventory, NewCommand newCommandForm)
        {
            InitializeComponent();
            _order = order;
            _inventory = inventory;
            _newCommandForm = newCommandForm;
            _purchaseOrder = new PurchaseOrder();
            resetForm();
        }
        private void resetForm()
        {
        }


        private async void order_product_cmb_TextChanged(object sender, EventArgs e)
        {
        }

        private void UpdateProductCombo(string searchText)
        {
        }

        private void order_provider_cmb_TextChanged(object sender, EventArgs e)
        {
        }

        private void orderForm_Load(object sender, EventArgs e)
        {
            UpdateOrderDatagrid();
            order_user_lbl.Text = $"Dernière modification par {Session.Username}";
        }

        private void UpdateOrderDatagrid()
        {
            string[] excludedColumns = { "User", "Provider", "Product" };
            DataTable dataTable = Common.GetDataTableFromEntity<PurchaseOrder>(_purchaseOrder, excludedColumns);

            var orders = _order.GetOrdersList(0, 100);


            foreach (PurchaseOrder order in orders)
            {
                DataRow row = Common.GetDataTableFromEntity(order).Rows[0]; // Get the first row from the DataTable
                dataTable.ImportRow(row);
            }

            if (dataTable.Rows.Count > 0)
            {
                //Remove unwanted row
                dataTable.Rows.RemoveAt(0);
            }

            orders_datagrid.DataSource = dataTable;
        }

        private async void order_save_btn_Click(object sender, EventArgs e)
        {
            _newCommandForm.edit = false;
            _newCommandForm.UpdatePurchaseData(new PurchaseOrder());

            if (_newCommandForm.ShowDialog() == DialogResult.OK)
            {
                UpdateOrderDatagrid();
            }
        }



        private void order_annuler_btn_Click(object sender, EventArgs e)
        {
        }

        public void SelectPurchaseOrder()
        {
            // Get the currently selected row (assuming single selection)
            if (orders_datagrid.SelectedRows.Count > 0) // Check if at least one row is selected
            {
                DataGridViewRow selectedRow = orders_datagrid.SelectedRows[0];
                _purchaseOrder = Common.ConvertRowToEntity<PurchaseOrder>(selectedRow);

            }
            else
            {
                resetForm();
            }
        }

        private void orders_datagrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (orders_datagrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = orders_datagrid.SelectedRows[0];
                if (selectedRow.Cells["received"].Value is true)
                {
                    order_receive_btn.Enabled = false;
                    order_enable_po_lbl.Visible = true;
                }
                else
                {
                    order_receive_btn.Enabled = true;
                    order_enable_po_lbl.Visible = false;
                }
            }
        }

        private void order_delete_po_btn_Click(object sender, EventArgs e)
        {
            if (orders_datagrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = orders_datagrid.SelectedRows[0];
                int poId = Convert.ToInt32(selectedRow.Cells["id"].Value);
                bool receivedPO = Convert.ToBoolean(selectedRow.Cells["received"].Value);

                if (poId > 0)
                {
                    DialogResult res = MessageBox.Show($"Etes-vous sur d'enlever le PO {poId} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        bool removed = _order.RemovePO(poId);
                        if (removed)
                        {
                            UpdateOrderDatagrid();
                            SelectPurchaseOrder();
                        }
                    }
                }

            }


            if (_purchaseOrder.id == 0) return;

            DialogResult result = MessageBox.Show($"Etes-vous sur d'enlever le PO {_purchaseOrder.id} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool removed = _order.RemovePO(_purchaseOrder.id);
                if (removed)
                {
                    UpdateOrderDatagrid();
                    SelectPurchaseOrder();
                }
            }
        }

        private void order_product_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void orders_datagrid_DoubleClick(object sender, EventArgs e)
        {
            var val = this.orders_datagrid.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;
            int orderId = int.Parse(val);

            var purchaseOrder = await _order.GetPurchaseOrderById(orderId);
            if (purchaseOrder == null) return;

            _newCommandForm.orderId = orderId;
            _newCommandForm.edit = true;
            _newCommandForm.UpdatePurchaseData(purchaseOrder);

            if (_newCommandForm.ShowDialog() == DialogResult.OK)
            {
                this.UpdateOrderDatagrid();
            }
        }

        private async void order_receive_btn_Click(object sender, EventArgs e)
        {
            if (orders_datagrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = orders_datagrid.SelectedRows[0];

                PurchaseOrder selectedPO = new PurchaseOrder
                {
                    id = Convert.ToInt32(selectedRow.Cells["id"].Value),
                    providerId = Convert.ToInt32(selectedRow.Cells["providerId"].Value),
                    productId = Convert.ToInt32(selectedRow.Cells["productId"].Value),
                    userId = Convert.ToInt32(selectedRow.Cells["userId"].Value),
                    quantity = Convert.ToInt32(selectedRow.Cells["quantity"].Value),
                    price = Convert.ToDouble(selectedRow.Cells["price"].Value),
                    received = true
                };

                bool updated = _inventory.UpdateInventory(selectedPO);
                if (updated)
                {
                    await _order.UpdatePurchaseOrder(selectedPO);
                    this.UpdateOrderDatagrid();
                }
            }
        }

        private void orders_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
