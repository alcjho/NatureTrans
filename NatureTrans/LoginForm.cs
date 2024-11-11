    using Microsoft.EntityFrameworkCore;
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
    internal partial class LoginForm : Form
    {
        private readonly LoginService _loginService;
        private readonly RegistrationForm _registration;
        private readonly Workspace _workspace;
        public LoginForm(LoginService loginService, RegistrationForm registration, Workspace workspace)
        {
            InitializeComponent();
            _loginService = loginService;
            _registration = registration;
            _workspace = workspace;
        }

        private void password_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _registration.ShowDialog();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            bool result = _loginService.VerifyLogin(username_txt.Text, password_txt.Text);

            if (!result)
            {
                MessageBox.Show("La connecxion à échoué utilisateur ou mot-de-passe invalide");
            }
            else
            {
                Console.WriteLine("Successful login! You will be redirected to your workspace");
                this.Hide();
                _workspace.WindowState = FormWindowState.Maximized;
                _workspace.Show();

            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
