namespace NatureTrans
{
    partial class ImportDataForm
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
            from_url_txt = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // from_url_txt
            // 
            from_url_txt.Location = new System.Drawing.Point(241, 155);
            from_url_txt.Name = "from_url_txt";
            from_url_txt.Size = new System.Drawing.Size(442, 27);
            from_url_txt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(32, 158);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(194, 20);
            label1.TabIndex = 1;
            label1.Text = "Addresse URL des données :";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(241, 216);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(442, 29);
            button1.TabIndex = 2;
            button1.Text = "Importer les données";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new System.Drawing.Point(241, 340);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(442, 29);
            progressBar1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(241, 314);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(66, 20);
            label2.TabIndex = 4;
            label2.Text = "Progrès :";
            // 
            // ImportDataForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label2);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(from_url_txt);
            Name = "ImportDataForm";
            Text = "ImportDataForm";
            Load += ImportDataForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox from_url_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
    }
}