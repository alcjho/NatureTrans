namespace NatureTrans
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            username = new System.Windows.Forms.TextBox();
            password = new System.Windows.Forms.TextBox();
            confirm_password = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            register_btn = new System.Windows.Forms.Button();
            login_return_btn = new System.Windows.Forms.Button();
            email = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            role_lst = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            ntdbDataSetBindingSource = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)ntdbDataSetBindingSource).BeginInit();
            SuspendLayout();
            // 
            // username
            // 
            username.Location = new System.Drawing.Point(341, 140);
            username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            username.Name = "username";
            username.Size = new System.Drawing.Size(251, 27);
            username.TabIndex = 0;
            // 
            // password
            // 
            password.Location = new System.Drawing.Point(341, 259);
            password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "Min 8 caracteres";
            password.Size = new System.Drawing.Size(251, 27);
            password.TabIndex = 3;
            // 
            // confirm_password
            // 
            confirm_password.Location = new System.Drawing.Point(341, 328);
            confirm_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            confirm_password.Name = "confirm_password";
            confirm_password.PasswordChar = '*';
            confirm_password.Size = new System.Drawing.Size(251, 27);
            confirm_password.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(262, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(279, 39);
            label1.TabIndex = 3;
            label1.Text = "Nouvel utilisateur";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(260, 148);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 20);
            label2.TabIndex = 4;
            label2.Text = "Utilisateur";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(237, 262);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(98, 20);
            label3.TabIndex = 5;
            label3.Text = "Mot de passe";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(175, 331);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(172, 20);
            label4.TabIndex = 6;
            label4.Text = "Confirmer Mot-de-passe";
            // 
            // register_btn
            // 
            register_btn.BackColor = System.Drawing.SystemColors.Highlight;
            register_btn.Location = new System.Drawing.Point(433, 466);
            register_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            register_btn.Name = "register_btn";
            register_btn.Size = new System.Drawing.Size(159, 50);
            register_btn.TabIndex = 7;
            register_btn.Text = "Soumettre";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += register_btn_Click;
            // 
            // login_return_btn
            // 
            login_return_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            login_return_btn.Location = new System.Drawing.Point(263, 469);
            login_return_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            login_return_btn.Name = "login_return_btn";
            login_return_btn.Size = new System.Drawing.Size(160, 48);
            login_return_btn.TabIndex = 8;
            login_return_btn.Text = "Retour a connexion";
            login_return_btn.UseVisualStyleBackColor = false;
            login_return_btn.Click += login_return_btn_Click;
            // 
            // email
            // 
            email.Location = new System.Drawing.Point(341, 204);
            email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            email.Name = "email";
            email.Size = new System.Drawing.Size(251, 27);
            email.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(285, 208);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(46, 20);
            label5.TabIndex = 4;
            label5.Text = "Email";
            label5.Click += label2_Click;
            // 
            // role_lst
            // 
            role_lst.FormattingEnabled = true;
            role_lst.Items.AddRange(new object[] { "1", "2", "3" });
            role_lst.Location = new System.Drawing.Point(341, 398);
            role_lst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            role_lst.Name = "role_lst";
            role_lst.Size = new System.Drawing.Size(250, 28);
            role_lst.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(266, 402);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(66, 20);
            label6.TabIndex = 6;
            label6.Text = "Privilège";
            label6.Click += label6_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 562);
            Controls.Add(role_lst);
            Controls.Add(email);
            Controls.Add(login_return_btn);
            Controls.Add(register_btn);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(confirm_password);
            Controls.Add(password);
            Controls.Add(username);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "RegistrationForm";
            Text = "Inscription";
            Load += register_form_Load;
            ((System.ComponentModel.ISupportInitialize)ntdbDataSetBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox confirm_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Button login_return_btn;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox role_lst;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource ntdbDataSetBindingSource;
    }
}