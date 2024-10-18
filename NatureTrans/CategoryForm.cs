using NatureTrans.Data;
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
    internal partial class CategoryForm : Form
    {
        private readonly InventoryService _inventory;
        public Category _category;

        public CategoryForm(InventoryService inventory)
        {
            InitializeComponent();
            _inventory = inventory;
            _category = new Category();

            category_active_chk.DataBindings.Add("Checked", _category, "active", true, DataSourceUpdateMode.OnPropertyChanged);
            category_name_txt.DataBindings.Add("Text", _category, "name", true, DataSourceUpdateMode.OnPropertyChanged);

            // Handle changes to the category name
            category_name_txt.TextChanged += category_name_txt_TextChanged;
        }


        private void updateCategoryList()
        {
            List<Category> categories = _inventory.getCategoryList();
            category_lst.DataSource = categories;
            category_lst.DisplayMember = "name";
            category_lst.ValueMember = "id";
        }

        public void ClearForm()
        {
            this.category_name_txt.Text = null;
            this.category_active_chk.Checked = false;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Category newCategory = new Category { active = _category.active, name = _category.name };

            if (newCategory != null && newCategory.name != null)
            {
                bool result = await _inventory.AddCategory(newCategory);
                if (result)
                {
                    DialogResult = DialogResult.OK;
                }
            }
            else 
            {
                throw new Exception("L'ajout a échoué - Le Nom de la catégorie est manquant");
            }

        }



        private void CategoryForm_Load(object sender, EventArgs e)
        {

            updateCategoryList();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void category_active_chk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void category_name_txt_TextChanged(object sender, EventArgs e)
        {
            _category.name = category_name_txt.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int categoryId = int.Parse(category_lst.SelectedValue.ToString());

            _inventory.DeleteCategoryById(categoryId);
            updateCategoryList();
        }
    }
}
