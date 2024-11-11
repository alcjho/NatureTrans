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
    internal partial class FindRecipeForm : Form
    {
        public readonly RecipeService _recipeService;
        public Recipe selectedRecipe { get; private set; }

        public FindRecipeForm(RecipeService recipeService)
        {
            InitializeComponent();
            _recipeService = recipeService;
        }

        private void FindRecipeForm_Load(object sender, EventArgs e)
        {
            find_recipe_datagrid.Items.Clear();
            find_recipe_datagrid.Columns.Clear();

            var recipes = _recipeService.GetRecipes(0, 100);
            find_recipe_datagrid.View = View.Details;
            find_recipe_datagrid.Columns.Add("name", 180);
            find_recipe_datagrid.Columns.Add("description", 500);

            foreach (var recipe in recipes)
            {
                ListViewItem item = new ListViewItem(recipe.name);
                item.SubItems.Add(recipe.description);
                item.Tag = recipe.id;
                find_recipe_datagrid.Items.Add(item);
            }
        }

        private void find_recipe_datagrid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private Recipe findRecipe() 
        {
            if (find_recipe_datagrid.SelectedItems.Count > 0)
            {
                var data = find_recipe_datagrid.SelectedItems[0];
                Recipe recipe = new Recipe
                {
                    id = (int)data.Tag,
                    name = data.Text,
                    description = data.SubItems[1].Text
                };

                selectedRecipe = recipe;
                return recipe;
            }
            return null;
        }
        private void find_recipe_datagrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var result = findRecipe();
            if (result != null && result.id != 0)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void find_recipe_open_btn_Click(object sender, EventArgs e)
        {
            var result = findRecipe();
            if (result != null && result.id != 0)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
