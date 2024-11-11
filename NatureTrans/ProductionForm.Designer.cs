namespace NatureTrans
{
    partial class ProductionForm
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
            production_recipe_lst = new System.Windows.Forms.ListView();
            production_find_txt = new System.Windows.Forms.TextBox();
            production_add_recipe_btn = new System.Windows.Forms.Button();
            production_rm_recipe_btn = new System.Windows.Forms.Button();
            production_recipe_datagrid = new System.Windows.Forms.DataGridView();
            label2 = new System.Windows.Forms.Label();
            production_price_txt = new System.Windows.Forms.TextBox();
            production_quantity_txt = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            production_unit_cmb = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            production_state_cmb = new System.Windows.Forms.ComboBox();
            production_name_txt = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            production_save_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)production_recipe_datagrid).BeginInit();
            SuspendLayout();
            // 
            // production_recipe_lst
            // 
            production_recipe_lst.FullRowSelect = true;
            production_recipe_lst.Location = new System.Drawing.Point(38, 170);
            production_recipe_lst.MultiSelect = false;
            production_recipe_lst.Name = "production_recipe_lst";
            production_recipe_lst.Size = new System.Drawing.Size(253, 338);
            production_recipe_lst.TabIndex = 0;
            production_recipe_lst.UseCompatibleStateImageBehavior = false;
            // 
            // production_find_txt
            // 
            production_find_txt.Location = new System.Drawing.Point(38, 118);
            production_find_txt.Name = "production_find_txt";
            production_find_txt.Size = new System.Drawing.Size(253, 27);
            production_find_txt.TabIndex = 1;
            production_find_txt.TextChanged += production_find_txt_TextChanged;
            // 
            // production_add_recipe_btn
            // 
            production_add_recipe_btn.Location = new System.Drawing.Point(314, 275);
            production_add_recipe_btn.Name = "production_add_recipe_btn";
            production_add_recipe_btn.Size = new System.Drawing.Size(132, 29);
            production_add_recipe_btn.TabIndex = 3;
            production_add_recipe_btn.Text = "Ajouter recette";
            production_add_recipe_btn.UseVisualStyleBackColor = true;
            production_add_recipe_btn.Click += production_add_recipe_btn_Click;
            // 
            // production_rm_recipe_btn
            // 
            production_rm_recipe_btn.Location = new System.Drawing.Point(375, 351);
            production_rm_recipe_btn.Name = "production_rm_recipe_btn";
            production_rm_recipe_btn.Size = new System.Drawing.Size(132, 29);
            production_rm_recipe_btn.TabIndex = 3;
            production_rm_recipe_btn.Text = "Enlever recette";
            production_rm_recipe_btn.UseVisualStyleBackColor = true;
            production_rm_recipe_btn.Click += production_rm_recipe_btn_Click;
            // 
            // production_recipe_datagrid
            // 
            production_recipe_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            production_recipe_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            production_recipe_datagrid.Location = new System.Drawing.Point(534, 250);
            production_recipe_datagrid.MultiSelect = false;
            production_recipe_datagrid.Name = "production_recipe_datagrid";
            production_recipe_datagrid.RowHeadersWidth = 51;
            production_recipe_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            production_recipe_datagrid.Size = new System.Drawing.Size(736, 258);
            production_recipe_datagrid.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(534, 38);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(279, 31);
            label2.TabIndex = 2;
            label2.Text = "Gestion de la production";
            // 
            // production_price_txt
            // 
            production_price_txt.Location = new System.Drawing.Point(534, 181);
            production_price_txt.Name = "production_price_txt";
            production_price_txt.Size = new System.Drawing.Size(152, 27);
            production_price_txt.TabIndex = 5;
            production_price_txt.TextChanged += production_price_txt_TextChanged;
            // 
            // production_quantity_txt
            // 
            production_quantity_txt.Location = new System.Drawing.Point(735, 182);
            production_quantity_txt.Name = "production_quantity_txt";
            production_quantity_txt.Size = new System.Drawing.Size(151, 27);
            production_quantity_txt.TabIndex = 5;
            production_quantity_txt.TextChanged += production_quantity_txt_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(534, 158);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(101, 20);
            label3.TabIndex = 6;
            label3.Text = "Prix de vente :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(735, 159);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(134, 20);
            label4.TabIndex = 6;
            label4.Text = "Quantité produite :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(931, 159);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(124, 20);
            label5.TabIndex = 6;
            label5.Text = "Unité de mesure :";
            // 
            // production_unit_cmb
            // 
            production_unit_cmb.FormattingEnabled = true;
            production_unit_cmb.Location = new System.Drawing.Point(934, 182);
            production_unit_cmb.Name = "production_unit_cmb";
            production_unit_cmb.Size = new System.Drawing.Size(151, 28);
            production_unit_cmb.TabIndex = 7;
            production_unit_cmb.SelectedIndexChanged += production_unit_cmb_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(534, 227);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(65, 20);
            label6.TabIndex = 6;
            label6.Text = "Recettes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(931, 95);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(152, 20);
            label7.TabIndex = 6;
            label7.Text = "Phase de production :";
            // 
            // production_state_cmb
            // 
            production_state_cmb.FormattingEnabled = true;
            production_state_cmb.Location = new System.Drawing.Point(934, 118);
            production_state_cmb.Name = "production_state_cmb";
            production_state_cmb.Size = new System.Drawing.Size(151, 28);
            production_state_cmb.TabIndex = 8;
            production_state_cmb.SelectedIndexChanged += production_state_cmb_SelectedIndexChanged;
            // 
            // production_name_txt
            // 
            production_name_txt.Location = new System.Drawing.Point(534, 118);
            production_name_txt.Name = "production_name_txt";
            production_name_txt.Size = new System.Drawing.Size(352, 27);
            production_name_txt.TabIndex = 1;
            production_name_txt.TextChanged += production_name_txt_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(38, 86);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(179, 28);
            label1.TabIndex = 2;
            label1.Text = "Trouver une recette";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(534, 93);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(163, 20);
            label8.TabIndex = 6;
            label8.Text = "Nom de la production :";
            // 
            // production_save_btn
            // 
            production_save_btn.BackColor = System.Drawing.Color.DodgerBlue;
            production_save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            production_save_btn.Location = new System.Drawing.Point(1140, 181);
            production_save_btn.Name = "production_save_btn";
            production_save_btn.Size = new System.Drawing.Size(130, 29);
            production_save_btn.TabIndex = 9;
            production_save_btn.Text = "Sauvegarder";
            production_save_btn.UseVisualStyleBackColor = false;
            production_save_btn.Click += production_save_btn_Click;
            // 
            // ProductionForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1367, 546);
            Controls.Add(production_save_btn);
            Controls.Add(production_state_cmb);
            Controls.Add(production_unit_cmb);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(production_quantity_txt);
            Controls.Add(production_price_txt);
            Controls.Add(production_recipe_datagrid);
            Controls.Add(production_rm_recipe_btn);
            Controls.Add(production_add_recipe_btn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(production_name_txt);
            Controls.Add(production_find_txt);
            Controls.Add(production_recipe_lst);
            Name = "ProductionForm";
            Text = "ProductionForm";
            FormClosed += ProductionForm_FormClosed;
            Load += ProductionForm_Load;
            Shown += ProductionForm_Shown;
            ((System.ComponentModel.ISupportInitialize)production_recipe_datagrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView production_recipe_lst;
        private System.Windows.Forms.TextBox production_find_txt;
        private System.Windows.Forms.Button production_add_recipe_btn;
        private System.Windows.Forms.Button production_rm_recipe_btn;
        private System.Windows.Forms.DataGridView production_recipe_datagrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox production_price_txt;
        private System.Windows.Forms.TextBox production_quantity_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox production_unit_cmb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox production_state_cmb;
        private System.Windows.Forms.TextBox production_name_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button production_save_btn;
    }
}