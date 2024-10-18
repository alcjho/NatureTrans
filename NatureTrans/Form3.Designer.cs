namespace NatureTrans
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.inventory_btn = new System.Windows.Forms.Button();
            this.recipe_btn = new System.Windows.Forms.Button();
            this.production_btn = new System.Windows.Forms.Button();
            this.welcome_txt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.production_btn);
            this.panel1.Controls.Add(this.recipe_btn);
            this.panel1.Controls.Add(this.inventory_btn);
            this.panel1.Location = new System.Drawing.Point(25, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 393);
            this.panel1.TabIndex = 0;
            // 
            // inventory_btn
            // 
            this.inventory_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_btn.Location = new System.Drawing.Point(25, 29);
            this.inventory_btn.Name = "inventory_btn";
            this.inventory_btn.Size = new System.Drawing.Size(169, 88);
            this.inventory_btn.TabIndex = 0;
            this.inventory_btn.Text = "Inventaire";
            this.inventory_btn.UseVisualStyleBackColor = true;
            // 
            // recipe_btn
            // 
            this.recipe_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipe_btn.Location = new System.Drawing.Point(26, 149);
            this.recipe_btn.Name = "recipe_btn";
            this.recipe_btn.Size = new System.Drawing.Size(168, 85);
            this.recipe_btn.TabIndex = 1;
            this.recipe_btn.Text = "Recettes";
            this.recipe_btn.UseVisualStyleBackColor = true;
            // 
            // production_btn
            // 
            this.production_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.production_btn.Location = new System.Drawing.Point(25, 266);
            this.production_btn.Name = "production_btn";
            this.production_btn.Size = new System.Drawing.Size(165, 90);
            this.production_btn.TabIndex = 2;
            this.production_btn.Text = "Production";
            this.production_btn.UseVisualStyleBackColor = true;
            // 
            // welcome_txt
            // 
            this.welcome_txt.AutoSize = true;
            this.welcome_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_txt.Location = new System.Drawing.Point(406, 30);
            this.welcome_txt.Name = "welcome_txt";
            this.welcome_txt.Size = new System.Drawing.Size(216, 42);
            this.welcome_txt.TabIndex = 1;
            this.welcome_txt.Text = "Bienvenue!";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welcome_txt);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Nature Trans - Production";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button production_btn;
        private System.Windows.Forms.Button recipe_btn;
        private System.Windows.Forms.Button inventory_btn;
        private System.Windows.Forms.Label welcome_txt;
    }
}