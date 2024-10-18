namespace NatureTrans
{
    partial class Workspace
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
            workspace_prod_panel = new System.Windows.Forms.Panel();
            prod_title_lbl = new System.Windows.Forms.Label();
            workspace_sales_panel = new System.Windows.Forms.Panel();
            prod_description_txt = new System.Windows.Forms.TextBox();
            prod_update_lbl = new System.Windows.Forms.Label();
            prod_creation_lbl = new System.Windows.Forms.Label();
            prod_discount_lbl = new System.Windows.Forms.Label();
            prod_price_lbl = new System.Windows.Forms.Label();
            prod_quantity_lbl = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            prod_desc_lbl = new System.Windows.Forms.Label();
            prod_id_lbl = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            prod_discount_txt = new System.Windows.Forms.TextBox();
            prod_price_txt = new System.Windows.Forms.TextBox();
            prod_quantity_txt = new System.Windows.Forms.TextBox();
            prod_capacity_txt = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            workspace_action_panel = new System.Windows.Forms.Panel();
            pay_btn = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            returns_btn = new System.Windows.Forms.Button();
            orders_btn = new System.Windows.Forms.Button();
            inventory_btn = new System.Windows.Forms.Button();
            welcome_txt = new System.Windows.Forms.Label();
            workspace_sales_panel.SuspendLayout();
            workspace_action_panel.SuspendLayout();
            SuspendLayout();
            // 
            // workspace_prod_panel
            // 
            workspace_prod_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            workspace_prod_panel.Location = new System.Drawing.Point(42, 58);
            workspace_prod_panel.Name = "workspace_prod_panel";
            workspace_prod_panel.Size = new System.Drawing.Size(297, 397);
            workspace_prod_panel.TabIndex = 0;
            workspace_prod_panel.Paint += workspace_prod_panel_Paint;
            // 
            // prod_title_lbl
            // 
            prod_title_lbl.AutoSize = true;
            prod_title_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            prod_title_lbl.Location = new System.Drawing.Point(99, 41);
            prod_title_lbl.Name = "prod_title_lbl";
            prod_title_lbl.Size = new System.Drawing.Size(109, 28);
            prod_title_lbl.TabIndex = 1;
            prod_title_lbl.Text = "Production";
            // 
            // workspace_sales_panel
            // 
            workspace_sales_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            workspace_sales_panel.Controls.Add(prod_description_txt);
            workspace_sales_panel.Controls.Add(prod_update_lbl);
            workspace_sales_panel.Controls.Add(prod_creation_lbl);
            workspace_sales_panel.Controls.Add(prod_discount_lbl);
            workspace_sales_panel.Controls.Add(prod_price_lbl);
            workspace_sales_panel.Controls.Add(prod_quantity_lbl);
            workspace_sales_panel.Controls.Add(label5);
            workspace_sales_panel.Controls.Add(prod_desc_lbl);
            workspace_sales_panel.Controls.Add(prod_id_lbl);
            workspace_sales_panel.Controls.Add(label2);
            workspace_sales_panel.Controls.Add(prod_discount_txt);
            workspace_sales_panel.Controls.Add(prod_price_txt);
            workspace_sales_panel.Controls.Add(prod_quantity_txt);
            workspace_sales_panel.Controls.Add(prod_capacity_txt);
            workspace_sales_panel.Location = new System.Drawing.Point(388, 58);
            workspace_sales_panel.Name = "workspace_sales_panel";
            workspace_sales_panel.Size = new System.Drawing.Size(901, 323);
            workspace_sales_panel.TabIndex = 2;
            // 
            // prod_description_txt
            // 
            prod_description_txt.Location = new System.Drawing.Point(28, 147);
            prod_description_txt.Multiline = true;
            prod_description_txt.Name = "prod_description_txt";
            prod_description_txt.Size = new System.Drawing.Size(287, 156);
            prod_description_txt.TabIndex = 3;
            // 
            // prod_update_lbl
            // 
            prod_update_lbl.AutoSize = true;
            prod_update_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            prod_update_lbl.Location = new System.Drawing.Point(620, 27);
            prod_update_lbl.Name = "prod_update_lbl";
            prod_update_lbl.Size = new System.Drawing.Size(259, 23);
            prod_update_lbl.TabIndex = 2;
            prod_update_lbl.Text = "Modifier le  09 Oct 2024 10:30:00";
            // 
            // prod_creation_lbl
            // 
            prod_creation_lbl.AutoSize = true;
            prod_creation_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            prod_creation_lbl.Location = new System.Drawing.Point(359, 27);
            prod_creation_lbl.Name = "prod_creation_lbl";
            prod_creation_lbl.Size = new System.Drawing.Size(233, 23);
            prod_creation_lbl.TabIndex = 2;
            prod_creation_lbl.Text = "Créée le 15 Jan 2024 05:00:00";
            // 
            // prod_discount_lbl
            // 
            prod_discount_lbl.AutoSize = true;
            prod_discount_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            prod_discount_lbl.Location = new System.Drawing.Point(617, 216);
            prod_discount_lbl.Name = "prod_discount_lbl";
            prod_discount_lbl.Size = new System.Drawing.Size(78, 28);
            prod_discount_lbl.TabIndex = 2;
            prod_discount_lbl.Text = "Rabais :";
            // 
            // prod_price_lbl
            // 
            prod_price_lbl.AutoSize = true;
            prod_price_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            prod_price_lbl.Location = new System.Drawing.Point(335, 216);
            prod_price_lbl.Name = "prod_price_lbl";
            prod_price_lbl.Size = new System.Drawing.Size(124, 28);
            prod_price_lbl.TabIndex = 2;
            prod_price_lbl.Text = "Prix de vente";
            // 
            // prod_quantity_lbl
            // 
            prod_quantity_lbl.AutoSize = true;
            prod_quantity_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            prod_quantity_lbl.Location = new System.Drawing.Point(614, 120);
            prod_quantity_lbl.Name = "prod_quantity_lbl";
            prod_quantity_lbl.Size = new System.Drawing.Size(102, 28);
            prod_quantity_lbl.TabIndex = 2;
            prod_quantity_lbl.Text = " Quantity :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(335, 120);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(96, 28);
            label5.TabIndex = 2;
            label5.Text = "Capacité :";
            // 
            // prod_desc_lbl
            // 
            prod_desc_lbl.AutoSize = true;
            prod_desc_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            prod_desc_lbl.Location = new System.Drawing.Point(24, 116);
            prod_desc_lbl.Name = "prod_desc_lbl";
            prod_desc_lbl.Size = new System.Drawing.Size(121, 28);
            prod_desc_lbl.TabIndex = 2;
            prod_desc_lbl.Text = "Description :";
            // 
            // prod_id_lbl
            // 
            prod_id_lbl.AutoSize = true;
            prod_id_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            prod_id_lbl.Location = new System.Drawing.Point(24, 27);
            prod_id_lbl.Name = "prod_id_lbl";
            prod_id_lbl.Size = new System.Drawing.Size(80, 28);
            prod_id_lbl.TabIndex = 2;
            prod_id_lbl.Text = "# Prod :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(53, 65);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(0, 20);
            label2.TabIndex = 1;
            // 
            // prod_discount_txt
            // 
            prod_discount_txt.Location = new System.Drawing.Point(617, 247);
            prod_discount_txt.Multiline = true;
            prod_discount_txt.Name = "prod_discount_txt";
            prod_discount_txt.Size = new System.Drawing.Size(262, 38);
            prod_discount_txt.TabIndex = 0;
            // 
            // prod_price_txt
            // 
            prod_price_txt.Location = new System.Drawing.Point(335, 247);
            prod_price_txt.Multiline = true;
            prod_price_txt.Name = "prod_price_txt";
            prod_price_txt.Size = new System.Drawing.Size(257, 38);
            prod_price_txt.TabIndex = 0;
            // 
            // prod_quantity_txt
            // 
            prod_quantity_txt.Location = new System.Drawing.Point(617, 151);
            prod_quantity_txt.Multiline = true;
            prod_quantity_txt.Name = "prod_quantity_txt";
            prod_quantity_txt.Size = new System.Drawing.Size(257, 38);
            prod_quantity_txt.TabIndex = 0;
            // 
            // prod_capacity_txt
            // 
            prod_capacity_txt.Location = new System.Drawing.Point(335, 151);
            prod_capacity_txt.Multiline = true;
            prod_capacity_txt.Name = "prod_capacity_txt";
            prod_capacity_txt.Size = new System.Drawing.Size(257, 38);
            prod_capacity_txt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(485, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 28);
            label1.TabIndex = 3;
            label1.Text = "Recettes";
            // 
            // workspace_action_panel
            // 
            workspace_action_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            workspace_action_panel.Controls.Add(pay_btn);
            workspace_action_panel.Controls.Add(button1);
            workspace_action_panel.Controls.Add(returns_btn);
            workspace_action_panel.Controls.Add(orders_btn);
            workspace_action_panel.Controls.Add(inventory_btn);
            workspace_action_panel.Location = new System.Drawing.Point(388, 396);
            workspace_action_panel.Name = "workspace_action_panel";
            workspace_action_panel.Size = new System.Drawing.Size(903, 59);
            workspace_action_panel.TabIndex = 4;
            // 
            // pay_btn
            // 
            pay_btn.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            pay_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            pay_btn.Location = new System.Drawing.Point(738, 13);
            pay_btn.Name = "pay_btn";
            pay_btn.Size = new System.Drawing.Size(142, 35);
            pay_btn.TabIndex = 0;
            pay_btn.Text = "Paiement";
            pay_btn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(749, 13);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(131, 35);
            button1.TabIndex = 0;
            button1.Text = "Retour";
            button1.UseVisualStyleBackColor = true;
            // 
            // returns_btn
            // 
            returns_btn.BackColor = System.Drawing.Color.FromArgb(255, 192, 128);
            returns_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            returns_btn.Location = new System.Drawing.Point(572, 13);
            returns_btn.Name = "returns_btn";
            returns_btn.Size = new System.Drawing.Size(142, 35);
            returns_btn.TabIndex = 0;
            returns_btn.Text = "Retour";
            returns_btn.UseVisualStyleBackColor = false;
            // 
            // orders_btn
            // 
            orders_btn.BackColor = System.Drawing.Color.RosyBrown;
            orders_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            orders_btn.Location = new System.Drawing.Point(187, 13);
            orders_btn.Name = "orders_btn";
            orders_btn.Size = new System.Drawing.Size(142, 35);
            orders_btn.TabIndex = 0;
            orders_btn.Text = "Commande";
            orders_btn.UseVisualStyleBackColor = false;
            orders_btn.Click += orders_btn_Click;
            // 
            // inventory_btn
            // 
            inventory_btn.BackColor = System.Drawing.Color.RosyBrown;
            inventory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            inventory_btn.Location = new System.Drawing.Point(24, 13);
            inventory_btn.Name = "inventory_btn";
            inventory_btn.Size = new System.Drawing.Size(142, 35);
            inventory_btn.TabIndex = 0;
            inventory_btn.Text = "Inventaire";
            inventory_btn.UseVisualStyleBackColor = false;
            inventory_btn.Click += inventory_btn_Click;
            // 
            // welcome_txt
            // 
            welcome_txt.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            welcome_txt.AutoSize = true;
            welcome_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            welcome_txt.Location = new System.Drawing.Point(921, 27);
            welcome_txt.Name = "welcome_txt";
            welcome_txt.Size = new System.Drawing.Size(368, 28);
            welcome_txt.TabIndex = 5;
            welcome_txt.Text = "Bienvenue sur votre espace de travail";
            welcome_txt.Click += welcome_txt_Click;
            // 
            // Workspace
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1329, 497);
            Controls.Add(welcome_txt);
            Controls.Add(workspace_action_panel);
            Controls.Add(label1);
            Controls.Add(workspace_sales_panel);
            Controls.Add(prod_title_lbl);
            Controls.Add(workspace_prod_panel);
            Name = "Workspace";
            Text = "Workspace";
            workspace_sales_panel.ResumeLayout(false);
            workspace_sales_panel.PerformLayout();
            workspace_action_panel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel workspace_prod_panel;
        private System.Windows.Forms.Label prod_title_lbl;
        private System.Windows.Forms.Panel workspace_sales_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel workspace_action_panel;
        private System.Windows.Forms.Button returns_btn;
        private System.Windows.Forms.Button orders_btn;
        private System.Windows.Forms.Button inventory_btn;
        private System.Windows.Forms.Button pay_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label welcome_txt;
        private System.Windows.Forms.TextBox prod_capacity_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prod_price_txt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label prod_id_lbl;
        private System.Windows.Forms.Label prod_update_lbl;
        private System.Windows.Forms.Label prod_creation_lbl;
        private System.Windows.Forms.Label prod_desc_lbl;
        private System.Windows.Forms.Label prod_discount_lbl;
        private System.Windows.Forms.Label prod_price_lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prod_discount_txt;
        private System.Windows.Forms.Label prod_quantity_lbl;
        private System.Windows.Forms.TextBox prod_quantity_txt;
        private System.Windows.Forms.TextBox prod_description_txt;
    }
}