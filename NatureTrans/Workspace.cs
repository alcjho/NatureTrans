using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using NatureTrans.Auth;
using NatureTrans.Data;
using NatureTrans.DTOs;
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
    internal partial class Workspace : Form
    {
        IServiceProvider _serviceProvider;
        InventoryForm _inventoryForm;
        orderForm _orderForm;
        RecipeForm _recipeForm;
        ProductionForm _productionForm;
        ProductionService _productionService;
        ProductionDTO selectedProduction;
        int selectedRecipeId = 0;
        public Workspace(
            IServiceProvider serviceProvider,
            InventoryForm inventoryForm,
            orderForm orderForm,
            RecipeForm recipeForm,
            ProductionService productionService
         )
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _inventoryForm = inventoryForm;
            _orderForm = orderForm;
            _recipeForm = recipeForm;
            _productionService = productionService;
            _productionForm = _serviceProvider.GetRequiredService<ProductionForm>();
            selectedProduction = new ProductionDTO();

        }

        private void Workspace_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to close ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)

                {
                    e.Cancel = true;
                }
            }
        }


        private void welcome_txt_Click(object sender, EventArgs e)
        {

        }

        private void inventory_btn_Click(object sender, EventArgs e)
        {
            _inventoryForm.Show();
        }

        private void orders_btn_Click(object sender, EventArgs e)
        {
            _orderForm.ShowDialog();
        }

        private void workspace_prod_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ws_new_production_btn_Click(object sender, EventArgs e)
        {
            ProductionForm _productionForm = _serviceProvider.GetRequiredService<ProductionForm>();
            DialogResult result = _productionForm.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Cancel)
            {
                UpdateProductionList();
            }
        }

        private void Workspace_Load(object sender, EventArgs e)
        {
            UpdateProductionList();
        }

        private void ws_show_recipes_btn_Click(object sender, EventArgs e)
        {
            _recipeForm.ShowDialog();
        }

        public void UpdateProductionList(string searchText = "")
        {
            List<Production> productions = _productionService.GetProductions(0, 100, searchText);

            ws_production_lst.Clear();
            ws_production_lst.View = View.Details;
            ws_production_lst.Columns.Add("Production", 100);
            ws_production_lst.Columns.Add("Recette", 180);

            foreach (var production in productions)
            {
                ListViewItem item = new ListViewItem(production.id.ToString());
                item.Tag = production.id;
                item.SubItems.Add(production.name);
                ws_production_lst.Items.Add(item);
            }
        }

        private void ws_production_lst_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ws_production_lst.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = ws_production_lst.SelectedItems[0];

                Production production = _productionService.GetProductionById(Convert.ToInt32(selectedItem.Tag));
                Console.WriteLine("production from workspace " + production);
                _productionForm.myProduction = production;
                _productionForm.myRecipeId = production.recipeId;
                _productionForm.ShowDialog();
            }
        }

        private void ws_production_lst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ws_search_production_TextChanged(object sender, EventArgs e)
        {
            if (ws_search_production.Text.Length >= 3 || ws_search_production.Text.Length == 0)
            {
                UpdateProductionList(ws_search_production.Text);
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
