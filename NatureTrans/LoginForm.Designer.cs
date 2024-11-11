namespace NatureTrans
{
    partial class LoginForm
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
            username_txt = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            password_txt = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            checkBox1 = new System.Windows.Forms.CheckBox();
            register_btn = new System.Windows.Forms.Button();
            login_btn = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // username_txt
            // 
            username_txt.Location = new System.Drawing.Point(305, 123);
            username_txt.Multiline = true;
            username_txt.Name = "username_txt";
            username_txt.Size = new System.Drawing.Size(341, 34);
            username_txt.TabIndex = 0;
            username_txt.TextChanged += password_txt_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(143, 126);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(156, 28);
            label1.TabIndex = 1;
            label1.Text = "Utilisateur/Email";
            label1.Click += label1_Click;
            // 
            // password_txt
            // 
            password_txt.Location = new System.Drawing.Point(305, 188);
            password_txt.Multiline = true;
            password_txt.Name = "password_txt";
            password_txt.PasswordChar = '*';
            password_txt.Size = new System.Drawing.Size(341, 34);
            password_txt.TabIndex = 1;
            password_txt.TextChanged += password_txt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(143, 191);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(135, 28);
            label2.TabIndex = 1;
            label2.Text = "Mot-de-passe\r\n";
            label2.Click += label1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(305, 240);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(157, 24);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Se souvenir de moi";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // register_btn
            // 
            register_btn.Location = new System.Drawing.Point(242, 300);
            register_btn.Name = "register_btn";
            register_btn.Size = new System.Drawing.Size(157, 55);
            register_btn.TabIndex = 3;
            register_btn.Text = "S'inscrire";
            register_btn.UseVisualStyleBackColor = true;
            register_btn.Click += button1_Click;
            // 
            // login_btn
            // 
            login_btn.Location = new System.Drawing.Point(424, 300);
            login_btn.Name = "login_btn";
            login_btn.Size = new System.Drawing.Size(159, 55);
            login_btn.TabIndex = 4;
            login_btn.Text = "Connexion";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(225, 35);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(358, 41);
            label3.TabIndex = 5;
            label3.Text = "Nature Trans Connexion";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label3);
            Controls.Add(login_btn);
            Controls.Add(register_btn);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password_txt);
            Controls.Add(username_txt);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label3;
    }
}