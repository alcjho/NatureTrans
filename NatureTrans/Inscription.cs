using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using NatureTrans.Auth;
using NatureTrans.Data;
using NatureTrans.Service;
using System.Runtime.InteropServices;


namespace NatureTrans
{
    internal partial class RegistrationForm : Form
    {
        RegistrationService _registration;
        public RegistrationForm(RegistrationService registration)
        {
            InitializeComponent();
            _registration = registration;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void register_btn_Click(object sender, EventArgs e)
        {
            
            if (confirm_password.Text != string.Empty || password.Text != string.Empty || username.Text != string.Empty)
            {
                if (password.Text == confirm_password.Text)
                {
                    Data.User newUser = new Data.User
                    {
                        username = username.Text,
                        email = email.Text,
                        password = password.Text,
                        hashAlgo = "sha512",
                        roleId = 1,
                    };

                    bool result = await _registration.AddUserAsync(newUser);
                    if (result)
                    {
                        MessageBox.Show("Successfully added user " + newUser.username);
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        
        private void register_form_Load(object sender, EventArgs e)
        {
        }

        private void login_return_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
