namespace NatureTrans
{
    partial class orderForm
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
            label1 = new System.Windows.Forms.Label();
            orders_datagrid = new System.Windows.Forms.DataGridView();
            label7 = new System.Windows.Forms.Label();
            order_user_lbl = new System.Windows.Forms.Label();
            order_save_btn = new System.Windows.Forms.Button();
            order_receive_btn = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            order_enable_po_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)orders_datagrid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(34, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(402, 31);
            label1.TabIndex = 1;
            label1.Text = "Gestion des commandes de produits";
            // 
            // orders_datagrid
            // 
            orders_datagrid.AllowUserToAddRows = false;
            orders_datagrid.AllowUserToDeleteRows = false;
            orders_datagrid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            orders_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orders_datagrid.Location = new System.Drawing.Point(34, 210);
            orders_datagrid.MultiSelect = false;
            orders_datagrid.Name = "orders_datagrid";
            orders_datagrid.ReadOnly = true;
            orders_datagrid.RowHeadersWidth = 51;
            orders_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            orders_datagrid.Size = new System.Drawing.Size(1177, 337);
            orders_datagrid.TabIndex = 5;
            orders_datagrid.CellContentClick += orders_datagrid_CellContentClick;
            orders_datagrid.DoubleClick += orders_datagrid_DoubleClick;
            orders_datagrid.MouseClick += orders_datagrid_MouseClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(34, 213);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(420, 23);
            label7.TabIndex = 1;
            label7.Text = "Selectionner la commande à supprimer ou à modifier.";
            // 
            // order_user_lbl
            // 
            order_user_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            order_user_lbl.AutoSize = true;
            order_user_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            order_user_lbl.ForeColor = System.Drawing.Color.Blue;
            order_user_lbl.Location = new System.Drawing.Point(1116, 45);
            order_user_lbl.Name = "order_user_lbl";
            order_user_lbl.Size = new System.Drawing.Size(95, 20);
            order_user_lbl.TabIndex = 7;
            order_user_lbl.Text = "Ajouté par : ";
            // 
            // order_save_btn
            // 
            order_save_btn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            order_save_btn.BackColor = System.Drawing.Color.DodgerBlue;
            order_save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            order_save_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            order_save_btn.Location = new System.Drawing.Point(547, 70);
            order_save_btn.Name = "order_save_btn";
            order_save_btn.Size = new System.Drawing.Size(174, 45);
            order_save_btn.TabIndex = 7;
            order_save_btn.Text = "Ajouter PO";
            order_save_btn.UseVisualStyleBackColor = false;
            order_save_btn.Click += order_save_btn_Click;
            // 
            // order_receive_btn
            // 
            order_receive_btn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            order_receive_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            order_receive_btn.Enabled = false;
            order_receive_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            order_receive_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            order_receive_btn.Location = new System.Drawing.Point(1043, 10);
            order_receive_btn.Name = "order_receive_btn";
            order_receive_btn.Size = new System.Drawing.Size(118, 46);
            order_receive_btn.TabIndex = 11;
            order_receive_btn.Text = "Recevoir PO";
            order_receive_btn.UseVisualStyleBackColor = false;
            order_receive_btn.Click += order_receive_btn_Click;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(order_enable_po_lbl);
            panel1.Controls.Add(order_receive_btn);
            panel1.Location = new System.Drawing.Point(34, 134);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1177, 70);
            panel1.TabIndex = 6;
            // 
            // order_enable_po_lbl
            // 
            order_enable_po_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            order_enable_po_lbl.AutoSize = true;
            order_enable_po_lbl.ForeColor = System.Drawing.Color.DarkOrange;
            order_enable_po_lbl.Location = new System.Drawing.Point(464, 23);
            order_enable_po_lbl.Name = "order_enable_po_lbl";
            order_enable_po_lbl.Size = new System.Drawing.Size(549, 20);
            order_enable_po_lbl.TabIndex = 12;
            order_enable_po_lbl.Text = "NB: le prix et la quantité d'une commande déjà recue ne peut plus être modifiées.";
            order_enable_po_lbl.Visible = false;
            // 
            // orderForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1249, 577);
            Controls.Add(order_user_lbl);
            Controls.Add(orders_datagrid);
            Controls.Add(order_save_btn);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "orderForm";
            Text = "orderForm";
            Load += orderForm_Load;
            ((System.ComponentModel.ISupportInitialize)orders_datagrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView orders_datagrid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label order_user_lbl;
        private System.Windows.Forms.Button order_save_btn;
        private System.Windows.Forms.Button order_receive_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label order_enable_po_lbl;
    }
}