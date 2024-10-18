namespace NatureTrans
{
    partial class UpdateInventoryForm
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
            product_add_lbl = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            product_name_txt = new System.Windows.Forms.TextBox();
            product_quantity_txt = new System.Windows.Forms.TextBox();
            product_desc_txt = new System.Windows.Forms.TextBox();
            product_state_cmb = new System.Windows.Forms.ComboBox();
            product_category_cmb = new System.Windows.Forms.ComboBox();
            product_cancel_btn = new System.Windows.Forms.Button();
            product_save_btn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // product_add_lbl
            // 
            product_add_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            product_add_lbl.AutoSize = true;
            product_add_lbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            product_add_lbl.Location = new System.Drawing.Point(12, 21);
            product_add_lbl.Name = "product_add_lbl";
            product_add_lbl.Size = new System.Drawing.Size(216, 31);
            product_add_lbl.TabIndex = 0;
            product_add_lbl.Text = "Ajouter un produit";
            product_add_lbl.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(121, 93);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(102, 20);
            label2.TabIndex = 1;
            label2.Text = "Nom produit :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(121, 282);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(95, 20);
            label3.TabIndex = 1;
            label3.Text = "Etat produit :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(121, 221);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(81, 20);
            label4.TabIndex = 1;
            label4.Text = "Catégorie :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(118, 156);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(131, 20);
            label5.TabIndex = 1;
            label5.Text = "Quantité en stock :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(121, 346);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(92, 20);
            label6.TabIndex = 1;
            label6.Text = "Description :";
            // 
            // product_name_txt
            // 
            product_name_txt.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            product_name_txt.Location = new System.Drawing.Point(296, 90);
            product_name_txt.Multiline = true;
            product_name_txt.Name = "product_name_txt";
            product_name_txt.Size = new System.Drawing.Size(317, 34);
            product_name_txt.TabIndex = 2;
            // 
            // product_quantity_txt
            // 
            product_quantity_txt.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            product_quantity_txt.Location = new System.Drawing.Point(296, 153);
            product_quantity_txt.Multiline = true;
            product_quantity_txt.Name = "product_quantity_txt";
            product_quantity_txt.Size = new System.Drawing.Size(317, 35);
            product_quantity_txt.TabIndex = 2;
            // 
            // product_desc_txt
            // 
            product_desc_txt.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            product_desc_txt.Location = new System.Drawing.Point(296, 343);
            product_desc_txt.Multiline = true;
            product_desc_txt.Name = "product_desc_txt";
            product_desc_txt.Size = new System.Drawing.Size(317, 111);
            product_desc_txt.TabIndex = 2;
            // 
            // product_state_cmb
            // 
            product_state_cmb.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            product_state_cmb.FormattingEnabled = true;
            product_state_cmb.Location = new System.Drawing.Point(296, 279);
            product_state_cmb.Name = "product_state_cmb";
            product_state_cmb.Size = new System.Drawing.Size(317, 28);
            product_state_cmb.TabIndex = 3;
            // 
            // product_category_cmb
            // 
            product_category_cmb.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            product_category_cmb.FormattingEnabled = true;
            product_category_cmb.Location = new System.Drawing.Point(296, 218);
            product_category_cmb.Name = "product_category_cmb";
            product_category_cmb.Size = new System.Drawing.Size(317, 28);
            product_category_cmb.TabIndex = 3;
            // 
            // product_cancel_btn
            // 
            product_cancel_btn.Location = new System.Drawing.Point(474, 472);
            product_cancel_btn.Name = "product_cancel_btn";
            product_cancel_btn.Size = new System.Drawing.Size(139, 54);
            product_cancel_btn.TabIndex = 4;
            product_cancel_btn.Text = "Annuler";
            product_cancel_btn.UseVisualStyleBackColor = true;
            product_cancel_btn.Click += product_cancel_btn_Click;
            // 
            // product_save_btn
            // 
            product_save_btn.Location = new System.Drawing.Point(296, 472);
            product_save_btn.Name = "product_save_btn";
            product_save_btn.Size = new System.Drawing.Size(139, 54);
            product_save_btn.TabIndex = 4;
            product_save_btn.Text = "Sauvegarder";
            product_save_btn.UseVisualStyleBackColor = true;
            product_save_btn.Click += product_save_btn_Click;
            // 
            // UpdateInventoryForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(730, 538);
            Controls.Add(product_save_btn);
            Controls.Add(product_cancel_btn);
            Controls.Add(product_category_cmb);
            Controls.Add(product_state_cmb);
            Controls.Add(product_desc_txt);
            Controls.Add(product_quantity_txt);
            Controls.Add(product_name_txt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(product_add_lbl);
            Name = "UpdateInventoryForm";
            Text = "Modifier inventaire de produits";
            Load += UpdateInventoryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label product_add_lbl;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox product_name_txt;
        private System.Windows.Forms.TextBox product_quantity_txt;
        private System.Windows.Forms.TextBox product_desc_txt;
        private System.Windows.Forms.ComboBox product_state_cmb;
        private System.Windows.Forms.ComboBox product_category_cmb;
        private System.Windows.Forms.Button product_cancel_btn;
        private System.Windows.Forms.Button product_save_btn;
    }
}