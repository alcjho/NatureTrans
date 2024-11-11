namespace NatureTrans
{
    partial class RecipeForm
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
            rcp_product_lst = new System.Windows.Forms.ListView();
            search_ingredient_txt = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            rcp_add_ingredient_btn = new System.Windows.Forms.Button();
            rcp_rm_ingredient_btn = new System.Windows.Forms.Button();
            rcp_title_txt = new System.Windows.Forms.TextBox();
            rcp_recipe_ingredients = new System.Windows.Forms.DataGridView();
            label2 = new System.Windows.Forms.Label();
            rcp_description_text = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            rcp_save_btn = new System.Windows.Forms.Button();
            rcp_open_recipe_btn = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)rcp_recipe_ingredients).BeginInit();
            SuspendLayout();
            // 
            // rcp_product_lst
            // 
            rcp_product_lst.FullRowSelect = true;
            rcp_product_lst.Location = new System.Drawing.Point(39, 131);
            rcp_product_lst.Name = "rcp_product_lst";
            rcp_product_lst.Size = new System.Drawing.Size(240, 343);
            rcp_product_lst.TabIndex = 0;
            rcp_product_lst.UseCompatibleStateImageBehavior = false;
            // 
            // search_ingredient_txt
            // 
            search_ingredient_txt.Location = new System.Drawing.Point(39, 89);
            search_ingredient_txt.Name = "search_ingredient_txt";
            search_ingredient_txt.Size = new System.Drawing.Size(240, 27);
            search_ingredient_txt.TabIndex = 1;
            search_ingredient_txt.TextChanged += search_ingredient_txt_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(39, 48);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(252, 28);
            label1.TabIndex = 2;
            label1.Text = "Search articles / ingrédients";
            // 
            // rcp_add_ingredient_btn
            // 
            rcp_add_ingredient_btn.Location = new System.Drawing.Point(316, 279);
            rcp_add_ingredient_btn.Name = "rcp_add_ingredient_btn";
            rcp_add_ingredient_btn.Size = new System.Drawing.Size(94, 29);
            rcp_add_ingredient_btn.TabIndex = 3;
            rcp_add_ingredient_btn.Text = "Ajouter";
            rcp_add_ingredient_btn.UseVisualStyleBackColor = true;
            rcp_add_ingredient_btn.Click += rcp_add_ingredient_btn_Click;
            // 
            // rcp_rm_ingredient_btn
            // 
            rcp_rm_ingredient_btn.Location = new System.Drawing.Point(402, 326);
            rcp_rm_ingredient_btn.Name = "rcp_rm_ingredient_btn";
            rcp_rm_ingredient_btn.Size = new System.Drawing.Size(94, 29);
            rcp_rm_ingredient_btn.TabIndex = 3;
            rcp_rm_ingredient_btn.Text = "Enlever";
            rcp_rm_ingredient_btn.UseVisualStyleBackColor = true;
            rcp_rm_ingredient_btn.Click += rcp_rm_ingredient_btn_Click;
            // 
            // rcp_title_txt
            // 
            rcp_title_txt.Location = new System.Drawing.Point(530, 130);
            rcp_title_txt.Name = "rcp_title_txt";
            rcp_title_txt.Size = new System.Drawing.Size(240, 27);
            rcp_title_txt.TabIndex = 1;
            rcp_title_txt.TextChanged += rcp_title_txt_TextChanged;
            // 
            // rcp_recipe_ingredients
            // 
            rcp_recipe_ingredients.AllowUserToAddRows = false;
            rcp_recipe_ingredients.AllowUserToResizeColumns = false;
            rcp_recipe_ingredients.AllowUserToResizeRows = false;
            rcp_recipe_ingredients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            rcp_recipe_ingredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rcp_recipe_ingredients.Location = new System.Drawing.Point(529, 326);
            rcp_recipe_ingredients.MultiSelect = false;
            rcp_recipe_ingredients.Name = "rcp_recipe_ingredients";
            rcp_recipe_ingredients.RowHeadersWidth = 51;
            rcp_recipe_ingredients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            rcp_recipe_ingredients.Size = new System.Drawing.Size(745, 200);
            rcp_recipe_ingredients.TabIndex = 4;
            rcp_recipe_ingredients.CellEndEdit += rcp_recipe_ingredients_CellEndEdit;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(529, 105);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(133, 20);
            label2.TabIndex = 5;
            label2.Text = "Titre de la recette :";
            // 
            // rcp_description_text
            // 
            rcp_description_text.Location = new System.Drawing.Point(529, 197);
            rcp_description_text.Multiline = true;
            rcp_description_text.Name = "rcp_description_text";
            rcp_description_text.Size = new System.Drawing.Size(745, 85);
            rcp_description_text.TabIndex = 6;
            rcp_description_text.TextChanged += rcp_description_text_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(530, 171);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(179, 20);
            label3.TabIndex = 5;
            label3.Text = "Description de la recette :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(801, 48);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(191, 28);
            label4.TabIndex = 2;
            label4.Text = "Gestion de la recette";
            // 
            // rcp_save_btn
            // 
            rcp_save_btn.Location = new System.Drawing.Point(959, 131);
            rcp_save_btn.Name = "rcp_save_btn";
            rcp_save_btn.Size = new System.Drawing.Size(130, 29);
            rcp_save_btn.TabIndex = 7;
            rcp_save_btn.Text = "Sauvegarder";
            rcp_save_btn.UseVisualStyleBackColor = true;
            rcp_save_btn.Click += rcp_save_btn_Click;
            // 
            // rcp_open_recipe_btn
            // 
            rcp_open_recipe_btn.Location = new System.Drawing.Point(1118, 131);
            rcp_open_recipe_btn.Name = "rcp_open_recipe_btn";
            rcp_open_recipe_btn.Size = new System.Drawing.Size(156, 29);
            rcp_open_recipe_btn.TabIndex = 7;
            rcp_open_recipe_btn.Text = "Recettes";
            rcp_open_recipe_btn.UseVisualStyleBackColor = true;
            rcp_open_recipe_btn.Click += rcp_open_recipe_btn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.SystemColors.Control;
            label5.Location = new System.Drawing.Point(528, 300);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(90, 20);
            label5.TabIndex = 5;
            label5.Text = "Ingrédients :";
            // 
            // RecipeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1339, 564);
            Controls.Add(rcp_open_recipe_btn);
            Controls.Add(rcp_save_btn);
            Controls.Add(rcp_description_text);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(rcp_recipe_ingredients);
            Controls.Add(rcp_rm_ingredient_btn);
            Controls.Add(rcp_add_ingredient_btn);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(rcp_title_txt);
            Controls.Add(search_ingredient_txt);
            Controls.Add(rcp_product_lst);
            Name = "RecipeForm";
            Text = "RecipeForm";
            Load += RecipeForm_Load;
            ((System.ComponentModel.ISupportInitialize)rcp_recipe_ingredients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView rcp_product_lst;
        private System.Windows.Forms.TextBox search_ingredient_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rcp_add_ingredient_btn;
        private System.Windows.Forms.Button rcp_rm_ingredient_btn;
        private System.Windows.Forms.TextBox rcp_title_txt;
        private System.Windows.Forms.DataGridView rcp_recipe_ingredients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rcp_description_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button rcp_save_btn;
        private System.Windows.Forms.Button rcp_open_recipe_btn;
        private System.Windows.Forms.Label label5;
    }
}