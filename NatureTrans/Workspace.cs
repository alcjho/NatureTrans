using NatureTrans.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace NatureTrans
{
    internal partial class Workspace : Form
    {
        InventoryForm _inventoryForm;
        orderForm _orderForm;

        public Workspace(InventoryForm inventoryForm, orderForm orderForm)
        {
            InitializeComponent();
            _inventoryForm = inventoryForm;
            _orderForm = orderForm;
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

        private void Workspace_Load(object sender, EventArgs e)
        {
            welcome_txt.Text = $"Bienvenue {Session.Username} sur votre espace de travail";
            MessageBox.Show(Session.Username + " is logged in");
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
            _orderForm.Show();
        }

        private void workspace_prod_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
