namespace NatureTrans
{
    partial class NewCommand
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
            order_add_btn = new System.Windows.Forms.Button();
            order_received_chk = new System.Windows.Forms.CheckBox();
            order_quantity_txt = new System.Windows.Forms.TextBox();
            order_comment_txt = new System.Windows.Forms.TextBox();
            order_price_txt = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            order_article_cmb = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            order_provider_cmb = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            order_remove_btn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // order_add_btn
            // 
            order_add_btn.BackColor = System.Drawing.SystemColors.Highlight;
            order_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            order_add_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            order_add_btn.Location = new System.Drawing.Point(621, 485);
            order_add_btn.Name = "order_add_btn";
            order_add_btn.Size = new System.Drawing.Size(134, 43);
            order_add_btn.TabIndex = 0;
            order_add_btn.Text = "Sauvegarder";
            order_add_btn.UseVisualStyleBackColor = false;
            order_add_btn.Click += order_add_btn_Click;
            // 
            // order_received_chk
            // 
            order_received_chk.AutoSize = true;
            order_received_chk.Location = new System.Drawing.Point(587, 259);
            order_received_chk.Name = "order_received_chk";
            order_received_chk.Size = new System.Drawing.Size(148, 24);
            order_received_chk.TabIndex = 2;
            order_received_chk.Text = "Commande reçue";
            order_received_chk.UseVisualStyleBackColor = true;
            // 
            // order_quantity_txt
            // 
            order_quantity_txt.Location = new System.Drawing.Point(96, 256);
            order_quantity_txt.Name = "order_quantity_txt";
            order_quantity_txt.Size = new System.Drawing.Size(125, 27);
            order_quantity_txt.TabIndex = 3;
            // 
            // order_comment_txt
            // 
            order_comment_txt.Location = new System.Drawing.Point(96, 330);
            order_comment_txt.Multiline = true;
            order_comment_txt.Name = "order_comment_txt";
            order_comment_txt.Size = new System.Drawing.Size(659, 136);
            order_comment_txt.TabIndex = 3;
            // 
            // order_price_txt
            // 
            order_price_txt.Location = new System.Drawing.Point(364, 256);
            order_price_txt.Name = "order_price_txt";
            order_price_txt.Size = new System.Drawing.Size(125, 27);
            order_price_txt.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(364, 233);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(40, 20);
            label1.TabIndex = 5;
            label1.Text = "Prix :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(92, 233);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(73, 20);
            label2.TabIndex = 6;
            label2.Text = "Quantité :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(96, 307);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(106, 20);
            label3.TabIndex = 7;
            label3.Text = "Commentaire :";
            // 
            // order_article_cmb
            // 
            order_article_cmb.FormattingEnabled = true;
            order_article_cmb.Location = new System.Drawing.Point(96, 98);
            order_article_cmb.Name = "order_article_cmb";
            order_article_cmb.Size = new System.Drawing.Size(393, 28);
            order_article_cmb.TabIndex = 8;
            order_article_cmb.TextUpdate += order_article_cmb_TextUpdate;
            order_article_cmb.TextChanged += order_article_cmb_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(94, 75);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(59, 20);
            label4.TabIndex = 9;
            label4.Text = "Article :";
            // 
            // order_provider_cmb
            // 
            order_provider_cmb.FormattingEnabled = true;
            order_provider_cmb.Location = new System.Drawing.Point(96, 173);
            order_provider_cmb.Name = "order_provider_cmb";
            order_provider_cmb.Size = new System.Drawing.Size(393, 28);
            order_provider_cmb.TabIndex = 10;
            order_provider_cmb.TextUpdate += order_provider_cmb_TextUpdate;
            order_provider_cmb.TextChanged += order_provider_cmb_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(94, 150);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(90, 20);
            label5.TabIndex = 9;
            label5.Text = "Fournisseur :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(96, 22);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(251, 31);
            label6.TabIndex = 11;
            label6.Text = "Commandes d'articles";
            // 
            // order_remove_btn
            // 
            order_remove_btn.BackColor = System.Drawing.Color.Red;
            order_remove_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            order_remove_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            order_remove_btn.Location = new System.Drawing.Point(96, 488);
            order_remove_btn.Name = "order_remove_btn";
            order_remove_btn.Size = new System.Drawing.Size(133, 40);
            order_remove_btn.TabIndex = 12;
            order_remove_btn.Text = "Supprimer";
            order_remove_btn.UseVisualStyleBackColor = false;
            order_remove_btn.Click += order_remove_btn_Click;
            // 
            // NewCommand
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(853, 569);
            Controls.Add(order_remove_btn);
            Controls.Add(label6);
            Controls.Add(order_provider_cmb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(order_article_cmb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(order_price_txt);
            Controls.Add(order_comment_txt);
            Controls.Add(order_quantity_txt);
            Controls.Add(order_received_chk);
            Controls.Add(order_add_btn);
            Name = "NewCommand";
            Text = "Ajout commande";
            Load += NewCommand_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button order_add_btn;
        private System.Windows.Forms.CheckBox order_received_chk;
        private System.Windows.Forms.TextBox order_quantity_txt;
        private System.Windows.Forms.TextBox order_comment_txt;
        private System.Windows.Forms.TextBox order_price_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox order_article_cmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox order_provider_cmb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button order_remove_btn;
    }
}