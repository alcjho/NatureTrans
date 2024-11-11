namespace NatureTrans
{
    partial class FindRecipeForm
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
            find_recipe_datagrid = new System.Windows.Forms.ListView();
            label1 = new System.Windows.Forms.Label();
            find_recipe_open_btn = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // find_recipe_datagrid
            // 
            find_recipe_datagrid.FullRowSelect = true;
            find_recipe_datagrid.Location = new System.Drawing.Point(41, 136);
            find_recipe_datagrid.Name = "find_recipe_datagrid";
            find_recipe_datagrid.Size = new System.Drawing.Size(719, 268);
            find_recipe_datagrid.TabIndex = 0;
            find_recipe_datagrid.UseCompatibleStateImageBehavior = false;
            find_recipe_datagrid.SelectedIndexChanged += find_recipe_datagrid_SelectedIndexChanged;
            find_recipe_datagrid.MouseDoubleClick += find_recipe_datagrid_MouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(41, 29);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(208, 31);
            label1.TabIndex = 1;
            label1.Text = "Ouvrir une recette";
            // 
            // find_recipe_open_btn
            // 
            find_recipe_open_btn.Location = new System.Drawing.Point(666, 91);
            find_recipe_open_btn.Name = "find_recipe_open_btn";
            find_recipe_open_btn.Size = new System.Drawing.Size(94, 29);
            find_recipe_open_btn.TabIndex = 2;
            find_recipe_open_btn.Text = "Ouvrir";
            find_recipe_open_btn.UseVisualStyleBackColor = true;
            find_recipe_open_btn.Click += find_recipe_open_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(39, 109);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(124, 20);
            label2.TabIndex = 3;
            label2.Text = "Base de recettes :";
            // 
            // FindRecipeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label2);
            Controls.Add(find_recipe_open_btn);
            Controls.Add(label1);
            Controls.Add(find_recipe_datagrid);
            Name = "FindRecipeForm";
            Text = "FindRecipeForm";
            Load += FindRecipeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView find_recipe_datagrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button find_recipe_open_btn;
        private System.Windows.Forms.Label label2;
    }
}