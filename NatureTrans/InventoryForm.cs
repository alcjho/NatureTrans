using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using static NatureTrans.Data.Product;

namespace NatureTrans
{
    internal partial class InventoryForm : Form
    {
        private readonly UpdateInventoryForm _updateInventoryForm;
        private readonly CategoryForm _categoryForm;
        private readonly InventoryService _inventory;
        private Product _product;
        private string mode = "Mode: Ajout";

        public InventoryForm(InventoryService inventory, UpdateInventoryForm updateInventoryForm, CategoryForm categoryForm)
        {
            InitializeComponent();
            _inventory = inventory;
            _updateInventoryForm = updateInventoryForm;
            _categoryForm = categoryForm;
            _product = new Product();
        }

        public DataTable GetDataTableFromEntity<T>(T entity)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            string[] excludedColumns = { "description", "Category", "quantity" };

            foreach (var property in typeof(T).GetProperties().Where(p => !excludedColumns.Contains(p.Name)))
            {
                if (property.CanRead)
                    
                {

                    Type underlyingType = Nullable.GetUnderlyingType(property.PropertyType);
                    DataColumn column = new DataColumn(property.Name, underlyingType ?? property.PropertyType);
                    dataTable.Columns.Add(column);
                }
            }

            var row = dataTable.NewRow();
            foreach (var property in typeof(T).GetProperties())
            {
                if (property.CanRead)
                {
                    string columnName = property.Name;
                    object value = property?.GetValue(entity);

                    if (value != null && dataTable.Columns.Contains(columnName)) // Check if column exists
                    {
                        row[columnName] = value ?? DBNull.Value;
                    }

                }
            }

            dataTable.Rows.Add(row);
            return dataTable;
        }


        private void UpdateProducts()
        {
            DataTable dataTable = GetDataTableFromEntity<Product>(_product);
            List<Product> products = _inventory.getProductList(0, 100);

            foreach (Product product in products)
            {
                DataRow row = GetDataTableFromEntity(product).Rows[0]; // Get the first row from the DataTable
                dataTable.ImportRow(row);
            }

            if (dataTable.Rows.Count > 0)
            {
                //Remove unwanted row
                dataTable.Rows.RemoveAt(0);
            }

            inv_product_datagrid.DataSource = dataTable;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void inv_product_name_lbl_Click(object sender, EventArgs e)
        {

        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            UpdateProducts();
        }

        private void prod_category_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(_product);
        }

        private void inv_product_qty_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void inv_product_name_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void inv_product_state_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void inv_new_btn_Click(object sender, EventArgs e)
        {
            _updateInventoryForm.clearForm();
            _updateInventoryForm.edit = false;

            if (_updateInventoryForm.ShowDialog() == DialogResult.OK)
            {
                UpdateProducts();
            };
        }

        private void product_list_lst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inv_cancel_btn_Click(object sender, EventArgs e)
        {

        }

        private void clearProduct()
        {

        }

        private async void inv_update_btn_Click(object sender, EventArgs e)
        {
            var val = this.inv_product_datagrid.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;
            int productId = int.Parse(val);

            var product = _inventory.getProductById(productId);
            if (product == null) return;

            _updateInventoryForm.productId = productId;
            _updateInventoryForm.edit = true;
            _updateInventoryForm.UpdateProduct(product);
            if (_updateInventoryForm.ShowDialog() == DialogResult.OK)
            {
                this.UpdateProducts();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void inv_product_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void inv_delete_btn_Click(object sender, EventArgs e)
        {
            var val = this.inv_product_datagrid.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;
            int productId = int.Parse(val);
            DialogResult result = MessageBox.Show($"Etes-vous sur d'enlever le produit {productId} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _inventory.DeleteProductById(productId);
            }


            this.UpdateProducts();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _categoryForm.ClearForm();
            _categoryForm.ShowDialog();
        }
    }
}
