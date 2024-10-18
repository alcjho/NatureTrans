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
    internal partial class UpdateInventoryForm : Form
    {
        InventoryService _inventory;
        public int productId;
        public UpdateInventoryForm(InventoryService inventory)
        {
            InitializeComponent();
            _inventory = inventory;

            this.DialogResult = DialogResult.Cancel;

            bindProductData();

            product_state_cmb.DataSource = Enum.GetValues(typeof(Product.ProdState));
            product_state_cmb.DisplayMember = "Name";

            product_category_cmb.DataSource = _inventory.getCategoryList();
            product_category_cmb.ValueMember = "id";
            product_category_cmb.DisplayMember = "name";
        }

        private void bindProductData()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public bool edit = false;

        public void UpdateProduct(Product product)
        {
            product_add_lbl.Text = "Modifier produit - No " + product.id;
            product_name_txt.Text = product.name;
            product_quantity_txt.Text = product.quantity.ToString();
            product_desc_txt.Text = product.description;
            product_state_cmb.SelectedItem = product.prodState;
            product_category_cmb.SelectedValue = product.categoryId;
        }

        private async void product_save_btn_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                name = product_name_txt.Text,
                description = product_desc_txt.Text,
                quantity = int.Parse(product_quantity_txt.Text),
                prodState = (Product.ProdState)product_state_cmb.SelectedItem,
                categoryId = (int)product_category_cmb.SelectedValue
            };

            if (!this.edit)
            {
                product_add_lbl.Text = "Ajouter un produit";
                
                int result = await _inventory.AddProduct(product);

                switch (result)
                {
                    case 0:
                        MessageBox.Show($"Product {product.name} identified by {product.reference} is already exists");
                        break;
                    case 1:
                        MessageBox.Show($"Product {product.name} was successfully added");
                        break;
                    case -1:
                        MessageBox.Show($"An error occured. Please check the console");
                        break;
                    case -2:
                        MessageBox.Show("Incomplete product - should have a name, a category and a state");
                        break;
                }
            }
            else
            {
                product.id = productId;
                int result = await _inventory.UpdateProduct(product);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void product_cancel_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void clearForm()
        {
            this.product_quantity_txt.Text = string.Empty;
            this.product_name_txt.Text = string.Empty;
            this.product_desc_txt.Text = string.Empty;
            this.product_state_cmb.SelectedIndex = -1;
            this.product_category_cmb.SelectedIndex = -1;
        }
        private void UpdateInventoryForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
