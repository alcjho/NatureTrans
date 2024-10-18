namespace NatureTrans
{
    partial class InventoryForm
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
            inv_new_btn = new System.Windows.Forms.Button();
            inv_update_btn = new System.Windows.Forms.Button();
            inv_product_datagrid = new System.Windows.Forms.DataGridView();
            inv_delete_btn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)inv_product_datagrid).BeginInit();
            SuspendLayout();
            // 
            // inv_new_btn
            // 
            inv_new_btn.BackColor = System.Drawing.Color.DarkSeaGreen;
            inv_new_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            inv_new_btn.Location = new System.Drawing.Point(34, 127);
            inv_new_btn.Name = "inv_new_btn";
            inv_new_btn.Size = new System.Drawing.Size(142, 41);
            inv_new_btn.TabIndex = 9;
            inv_new_btn.Text = "Ajouter produit";
            inv_new_btn.UseVisualStyleBackColor = false;
            inv_new_btn.Click += inv_new_btn_Click;
            // 
            // inv_update_btn
            // 
            inv_update_btn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            inv_update_btn.BackColor = System.Drawing.Color.SandyBrown;
            inv_update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            inv_update_btn.Location = new System.Drawing.Point(738, 127);
            inv_update_btn.Name = "inv_update_btn";
            inv_update_btn.Size = new System.Drawing.Size(130, 41);
            inv_update_btn.TabIndex = 9;
            inv_update_btn.Text = "Modifier Produit";
            inv_update_btn.UseVisualStyleBackColor = false;
            inv_update_btn.Click += inv_update_btn_Click;
            // 
            // inv_product_datagrid
            // 
            inv_product_datagrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            inv_product_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            inv_product_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inv_product_datagrid.Location = new System.Drawing.Point(34, 188);
            inv_product_datagrid.MultiSelect = false;
            inv_product_datagrid.Name = "inv_product_datagrid";
            inv_product_datagrid.RowHeadersWidth = 51;
            inv_product_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            inv_product_datagrid.Size = new System.Drawing.Size(980, 409);
            inv_product_datagrid.TabIndex = 11;
            inv_product_datagrid.CellContentClick += inv_product_datagrid_CellContentClick;
            // 
            // inv_delete_btn
            // 
            inv_delete_btn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            inv_delete_btn.BackColor = System.Drawing.Color.Red;
            inv_delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            inv_delete_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            inv_delete_btn.Location = new System.Drawing.Point(888, 127);
            inv_delete_btn.Name = "inv_delete_btn";
            inv_delete_btn.Size = new System.Drawing.Size(125, 43);
            inv_delete_btn.TabIndex = 12;
            inv_delete_btn.Text = "Enlever produit";
            inv_delete_btn.UseVisualStyleBackColor = false;
            inv_delete_btn.Click += inv_delete_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(34, 36);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(256, 31);
            label1.TabIndex = 13;
            label1.Text = "Gestion de l'inventaire";
            label1.Click += label1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new System.Drawing.Point(933, 45);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(80, 20);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Catégories";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1071, 645);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(inv_delete_btn);
            Controls.Add(inv_product_datagrid);
            Controls.Add(inv_update_btn);
            Controls.Add(inv_new_btn);
            Name = "InventoryForm";
            Text = "InventoryFormcs";
            Load += InventoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)inv_product_datagrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button inv_new_btn;
        private System.Windows.Forms.Button inv_update_btn;
        private System.Windows.Forms.DataGridView inv_product_datagrid;
        private System.Windows.Forms.Button inv_delete_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}