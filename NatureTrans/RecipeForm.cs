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

namespace NatureTrans
{
    internal partial class RecipeForm : Form
    {
        public readonly InventoryService _inventory;
        public readonly RecipeService _recipe;
        public FindRecipeForm _findRecipeForm;
        public Recipe myRecipe;
        public List<dynamic> products;
        public List<IngredientDTO> myRecipeIngredients;
        public RecipeForm(InventoryService inventory, RecipeService recipe, FindRecipeForm findRecipeForm)
        {
            InitializeComponent();
            _inventory = inventory;
            _recipe = recipe;
            _findRecipeForm = findRecipeForm;
            myRecipe = new Recipe();
            products = new List<dynamic>();
            myRecipeIngredients = new List<IngredientDTO>();
        }

        private void RecipeForm_Load(object sender, EventArgs e)
        {
            products = _inventory.GetProductWithCategory(0, 100);
            loadProductList();
            UpdateDatagrid();
        }

        private void UpdateProductListView(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                products = _inventory.GetProductWithCategory(0, 100);
            }
            else
            {
                products = _inventory.GetFilteredProductWithCategory(searchText);
            }
            
            loadProductList();
        }

        public void loadProductList()
        {
            rcp_product_lst.Clear();
            rcp_product_lst.View = View.Details;
            rcp_product_lst.Columns.Add("name", 100);
            rcp_product_lst.Columns.Add("category", 150);

            foreach (var product in products)
            {
                ListViewItem item = new ListViewItem(product.name);
                item.SubItems.Add(product.categoryName);
                item.Tag = product.id;
                rcp_product_lst.Items.Add(item);
            }
        }

        private void UpdateFormData()
        {
            rcp_title_txt.Text = myRecipe.name;
            rcp_description_text.Text = myRecipe.description;
        }

        public void UpdateDatagrid()
        {
            rcp_recipe_ingredients.DataSource = null;
            rcp_recipe_ingredients.Rows.Clear();

            string[] excludedColumns = { };
            IngredientDTO recipeIngredient = new IngredientDTO();

            DataTable dataTable = Common.GetDataTableFromEntity<IngredientDTO>(recipeIngredient, excludedColumns);

            var ingredients = _recipe.GetRecipeIngredients(myRecipe.id);

            foreach (IngredientDTO ingredient in ingredients)
            {
                DataRow row = Common.GetDataTableFromEntity(ingredient).Rows[0]; // Get the first row from the DataTable
                dataTable.ImportRow(row);
            }

            if (dataTable.Rows.Count > 0)
            {
                dataTable.Rows.RemoveAt(0);
            }

            rcp_recipe_ingredients.DataSource = dataTable;
        }

        private async void rcp_add_ingredient_btn_Click(object sender, EventArgs e)
        {
            if (rcp_product_lst.Items.Count > 0)
            {
                var selectedItem = rcp_product_lst.SelectedItems[0];
                var lastRecipeId = _recipe.GetLastRecipeId();
                var recipeName = lastRecipeId == 0 ? "recipe-0" : $"recipe-{lastRecipeId + 1}";
                int productId = (int)selectedItem.Tag;

                if (myRecipe.id == 0)
                {
                    myRecipe = new Recipe
                    {
                        name = recipeName,
                        description = recipeName
                    };

                    myRecipe = await _recipe.createRecipe(myRecipe);
                }

                bool result = await _recipe.AddIngredient(myRecipe, productId);
                if (result)
                {
                    UpdateFormData();
                    UpdateDatagrid();
                }
            }
        }

        private void rcp_open_recipe_btn_Click(object sender, EventArgs e)
        {
            if (_findRecipeForm.ShowDialog() == DialogResult.OK)
            {
                myRecipe = _findRecipeForm.selectedRecipe;
                UpdateFormData();
                UpdateDatagrid();
            }
        }

        private async void rcp_recipe_ingredients_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Get the current row
            var row = rcp_recipe_ingredients.Rows[e.RowIndex];

            // Extract updated values
            int ingredientId = (int)row.Cells["id"].Value; // Assuming "Id" is the primary key column
            double updatedQuantity = Convert.ToDouble(row.Cells["Quantité"].Value);
            string updatedNote = row.Cells["note"].Value.ToString();
            string unit = row.Cells["Unité"].Value.ToString();

            if (Enum.TryParse(typeof(Unit), unit, true, out object result))
            {
                Unit updatedUnit = (Unit)result;

                RecipeIngredient newIngredient = new RecipeIngredient
                {
                    id = ingredientId,
                    ingredient_qty = updatedQuantity,
                    ingredient_unit = updatedUnit,
                    note = updatedNote
                };

                // Call your update service method with the updated data
                var updateIngredient = await _recipe.UpdateRecipeIngredient(newIngredient);
                if (updateIngredient)
                {
                    Console.WriteLine($"updated {newIngredient} successfully");
                }
                else
                {
                    Console.WriteLine($"error updating {newIngredient}");
                }
            }
            else
            {
                MessageBox.Show("Unité de mesure invalide");
            }

        }

        private async void rcp_save_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rcp_title_txt.Text))
            {
                MessageBox.Show("Le titre de la recette est obligatoire", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (myRecipe.id == 0)
            {
                myRecipe = await _recipe.createRecipe(myRecipe);
                MessageBox.Show("Recette créée avec succès", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                bool result = await _recipe.UpdateRecipe(myRecipe);
                if (result)
                {
                    await _recipe.UpdateIngredientsRecipe(myRecipe.id, myRecipe.name);
                    MessageBox.Show("Recette modifiée avec succès", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            UpdateFormData();
            UpdateDatagrid();
        }

        private void rcp_title_txt_TextChanged(object sender, EventArgs e)
        {
            myRecipe.name = rcp_title_txt.Text;
        }

        private void rcp_description_text_TextChanged(object sender, EventArgs e)
        {
            myRecipe.description = rcp_description_text.Text;
        }

        private void rcp_rm_ingredient_btn_Click(object sender, EventArgs e)
        {
            if (rcp_recipe_ingredients.Rows.Count > 0)
            {
                var ingredient = rcp_recipe_ingredients.SelectedRows[0];
                int ingredientId = (int)ingredient.Cells["id"].Value;


                if (ingredientId > 0)
                {
                    DialogResult res = MessageBox.Show($"Etes-vous sur d'enlever l'ingredient {ingredientId} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        bool removed = _recipe.RemoveIngredient(ingredientId);
                        if (removed)
                        {
                            UpdateDatagrid();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Selectionner d'abord un ingredient dans le tableau", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void search_ingredient_txt_TextChanged(object sender, EventArgs e)
        {
            UpdateProductListView(search_ingredient_txt.Text);
        }
    }
}
