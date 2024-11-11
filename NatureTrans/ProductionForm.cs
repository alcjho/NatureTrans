using NatureTrans.Data;
using NatureTrans.DTOs;
using NatureTrans.Service;
using NatureTrans.Types;
using NatureTrans.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace NatureTrans
{
    internal partial class ProductionForm : Form
    {
        private readonly InventoryService _inventory;
        private readonly RecipeService _recipe;
        private readonly ProductionService _production;
        public Production myProduction;
        public int? myRecipeId { get; set; }
        public ProductionForm(InventoryService inventory, RecipeService recipe, ProductionService production)
        {
            InitializeComponent();
            _recipe = recipe;
            _production = production;
            _inventory = inventory;
            myProduction = new Production();
            production_state_cmb.SelectedItem = null;
            production_unit_cmb.SelectedItem = null;
        }

        private void ProductionForm_Load(object sender, EventArgs e)
        {

        }

        public void UpdateFormData()
        {
            var unit = myProduction.prod_unit;
            var state = myProduction.prod_state;

            var unitList = new List<object> { "Select..." }; // Placeholder item
            unitList.AddRange(Enum.GetValues(typeof(Unit)).Cast<object>()); // Add enum values
            production_unit_cmb.DataSource = unitList;
            production_unit_cmb.SelectedItem = myProduction.prod_unit == default(Unit) ? "Select..." : myProduction.prod_unit;

            var stateList = new List<object> { "Select..." }; // Placeholder item
            stateList.AddRange(Enum.GetValues(typeof(Phases)).Cast<object>()); // Add enum values
            production_state_cmb.DataSource = stateList;
            production_state_cmb.SelectedItem = myProduction.prod_state == default(Phases) ? "Select..." : myProduction.prod_state;

            production_name_txt.Text = myProduction?.name;
            production_quantity_txt.Text = myProduction?.prod_quantity.ToString();
            production_price_txt.Text = myProduction?.price.ToString();
        }

        public void UpdateDatagrid()
        {
            production_recipe_datagrid.DataSource = null;
            production_recipe_datagrid.Rows.Clear();

            string[] excludedColumns = { "Recette" };
            IngredientDTO recipeIngredient = new IngredientDTO();

            DataTable dataTable = Common.GetDataTableFromEntity(recipeIngredient, excludedColumns);

            var recipeId = myRecipeId.HasValue ? myRecipeId : 0;
            var ingredients = _recipe.GetRecipeIngredients((int)recipeId);

            foreach (IngredientDTO ingredient in ingredients)
            {
                DataRow row = Common.GetDataTableFromEntity(ingredient).Rows[0];
                dataTable.ImportRow(row);
            }

            if (dataTable.Rows.Count > 0)
            {
                dataTable.Rows.RemoveAt(0);
            }

            production_recipe_datagrid.DataSource = dataTable;
        }

        private async void production_add_recipe_btn_Click(object sender, EventArgs e)
        {
            if (production_recipe_lst.SelectedItems.Count > 0)
            {
                production_save_btn.Enabled = true;
                var selectedItem = production_recipe_lst.SelectedItems[0];
                int recipeId = (int)selectedItem.Tag;


                if (myProduction.id > 0)
                {
                    Recipe recipe = _recipe.GetRecipeById(recipeId);
                    myRecipeId = recipe.id;

                    var result = await _production.AddRecipeToProduction(myProduction, recipe.id);
                    Console.WriteLine(result);
                }

                UpdateFormData();
                UpdateDatagrid();
            }
        }

        private void production_name_txt_TextChanged(object sender, EventArgs e)
        {
            if (myProduction != null)
                myProduction.name = production_name_txt.Text;
        }

        private void production_price_txt_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(production_price_txt.Text, out double price) && myProduction != null)
            {
                myProduction.price = price;
            }
        }

        private void production_unit_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Enum.TryParse(production_unit_cmb.Text, out Unit result))
            {
                if (myProduction != null)
                    myProduction.prod_unit = result;
            }
        }

        private void production_state_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (production_state_cmb.Text != "Select...")
            {
                myProduction.prod_state = (Phases)Enum.Parse(typeof(Phases), production_state_cmb.Text);
            }
        }

        private void production_quantity_txt_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(production_quantity_txt.Text, out double quantity) && myProduction != null)
                myProduction.prod_quantity = quantity;
        }

        private async void production_save_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"new production: {myProduction}");

            if (string.IsNullOrWhiteSpace(production_name_txt.Text))
            {
                MessageBox.Show("Le titre de la production est obligatoire", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (myProduction?.id == 0)
            {
                myProduction = await _production.createProduction(myProduction);
                if (myProduction != null && myProduction.id > 0)
                {
                    MessageBox.Show($"Production {myProduction.id} créée avec succès", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                myProduction = await _production.UpdateProduction(myProduction);
                Console.WriteLine("updated production " + myProduction);
            }

            UpdateFormData();
            UpdateDatagrid();
        }

        private async void production_rm_recipe_btn_Click(object sender, EventArgs e)
        {
            if (myProduction.id > 0 && myRecipeId != null)
            {
                DialogResult result = MessageBox.Show($"Etes-vous sur d'enlever la recette de la production {myProduction.id} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == result)
                {
                    bool removed = await _production.RemoveRecipeFromProduction((int)myRecipeId);
                    Console.WriteLine("removed : " + removed);
                    if (removed)
                    {
                        myRecipeId = null;
                        UpdateDatagrid();
                    }
                    else
                    {
                        MessageBox.Show("Désolé. La production n'a pas été supprimée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Aucune recette n'a été ajoutée dans cette production", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProductionForm_Shown(object sender, EventArgs e)
        {
            // enable buttons only on edit mode
            if (myProduction?.id > 0)
            {
                production_add_recipe_btn.Enabled = true;
                production_rm_recipe_btn.Enabled = true;
            }
            else
            {
                production_add_recipe_btn.Enabled = false;
                production_rm_recipe_btn.Enabled = false;
            }

            production_recipe_lst.Items.Clear();
            production_recipe_lst.Columns.Clear();

            var recipes = _recipe.GetRecipes(0, 100);
            production_recipe_lst.View = View.Details;
            production_recipe_lst.Columns.Add("ID", 50);
            production_recipe_lst.Columns.Add("name", 180);

            foreach (var recipe in recipes)
            {
                ListViewItem item = new ListViewItem(recipe.id.ToString());
                item.Tag = recipe.id;
                item.SubItems.Add(recipe.name);
                production_recipe_lst.Items.Add(item);
            }

            UpdateFormData();
            UpdateDatagrid();

        }

        private void ProductionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void production_find_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
