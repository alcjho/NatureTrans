namespace NatureTrans
{
    partial class CategoryForm
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
            add_category_btn = new System.Windows.Forms.Button();
            category_lst = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            category_name_txt = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            category_active_chk = new System.Windows.Forms.CheckBox();
            button1 = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // add_category_btn
            // 
            add_category_btn.BackColor = System.Drawing.Color.RoyalBlue;
            add_category_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            add_category_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            add_category_btn.Location = new System.Drawing.Point(446, 26);
            add_category_btn.Name = "add_category_btn";
            add_category_btn.Size = new System.Drawing.Size(148, 39);
            add_category_btn.TabIndex = 0;
            add_category_btn.Text = "Sauvegarder";
            add_category_btn.UseVisualStyleBackColor = false;
            add_category_btn.Click += button1_Click;
            // 
            // category_lst
            // 
            category_lst.FormattingEnabled = true;
            category_lst.Location = new System.Drawing.Point(68, 237);
            category_lst.MultiColumn = true;
            category_lst.Name = "category_lst";
            category_lst.Size = new System.Drawing.Size(651, 184);
            category_lst.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(68, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(254, 31);
            label1.TabIndex = 2;
            label1.Text = "Gestion des catégories";
            // 
            // category_name_txt
            // 
            category_name_txt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            category_name_txt.Location = new System.Drawing.Point(51, 25);
            category_name_txt.Multiline = true;
            category_name_txt.Name = "category_name_txt";
            category_name_txt.PlaceholderText = "Nom unique de la catégorie";
            category_name_txt.Size = new System.Drawing.Size(360, 40);
            category_name_txt.TabIndex = 3;
            category_name_txt.TextChanged += category_name_txt_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(category_active_chk);
            panel1.Controls.Add(category_name_txt);
            panel1.Controls.Add(add_category_btn);
            panel1.Location = new System.Drawing.Point(68, 88);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(651, 125);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // category_active_chk
            // 
            category_active_chk.AutoSize = true;
            category_active_chk.Location = new System.Drawing.Point(51, 83);
            category_active_chk.Name = "category_active_chk";
            category_active_chk.Size = new System.Drawing.Size(139, 24);
            category_active_chk.TabIndex = 5;
            category_active_chk.Text = "Catégorie active";
            category_active_chk.UseVisualStyleBackColor = true;
            category_active_chk.CheckedChanged += category_active_chk_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Red;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            button1.Location = new System.Drawing.Point(558, 466);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(161, 36);
            button1.TabIndex = 6;
            button1.Text = "Enlever catégorie";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 518);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(category_lst);
            Name = "CategoryForm";
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button add_category_btn;
        private System.Windows.Forms.ListBox category_lst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox category_name_txt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox category_active_chk;
        private System.Windows.Forms.Button button1;
    }
}