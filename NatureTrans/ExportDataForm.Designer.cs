namespace NatureTrans
{
    partial class ExportDataForm
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
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            label1 = new System.Windows.Forms.Label();
            upload_provider_cmb = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            start_upload_btn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(239, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(399, 31);
            label1.TabIndex = 0;
            label1.Text = "Televerser le backup de vos données";
            // 
            // upload_provider_cmb
            // 
            upload_provider_cmb.FormattingEnabled = true;
            upload_provider_cmb.Items.AddRange(new object[] { "Google drive", "Dropbox" });
            upload_provider_cmb.Location = new System.Drawing.Point(251, 168);
            upload_provider_cmb.Name = "upload_provider_cmb";
            upload_provider_cmb.Size = new System.Drawing.Size(373, 28);
            upload_provider_cmb.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(129, 171);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(116, 20);
            label2.TabIndex = 2;
            label2.Text = "Televerser avec :";
            // 
            // start_upload_btn
            // 
            start_upload_btn.Location = new System.Drawing.Point(251, 250);
            start_upload_btn.Name = "start_upload_btn";
            start_upload_btn.Size = new System.Drawing.Size(373, 29);
            start_upload_btn.TabIndex = 3;
            start_upload_btn.Text = "Demarrer le téleversement";
            start_upload_btn.UseVisualStyleBackColor = true;
            start_upload_btn.Click += start_upload_btn_Click;
            // 
            // ExportDataForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(start_upload_btn);
            Controls.Add(label2);
            Controls.Add(upload_provider_cmb);
            Controls.Add(label1);
            Name = "ExportDataForm";
            Text = "ExportDataForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox upload_provider_cmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button start_upload_btn;
    }
}