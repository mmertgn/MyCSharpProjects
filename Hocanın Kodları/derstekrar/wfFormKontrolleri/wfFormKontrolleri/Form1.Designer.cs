namespace wfFormKontrolleri
{
    partial class Form1
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
            this.btnBilgi = new System.Windows.Forms.Button();
            this.txtBilgi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBilgi
            // 
            this.btnBilgi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBilgi.Location = new System.Drawing.Point(110, 98);
            this.btnBilgi.Name = "btnBilgi";
            this.btnBilgi.Size = new System.Drawing.Size(75, 23);
            this.btnBilgi.TabIndex = 0;
            this.btnBilgi.Text = "Mesaj";
            this.btnBilgi.UseVisualStyleBackColor = true;
            this.btnBilgi.Click += new System.EventHandler(this.btnBilgi_Click);
            // 
            // txtBilgi
            // 
            this.txtBilgi.Location = new System.Drawing.Point(93, 41);
            this.txtBilgi.Multiline = true;
            this.txtBilgi.Name = "txtBilgi";
            this.txtBilgi.ReadOnly = true;
            this.txtBilgi.Size = new System.Drawing.Size(120, 51);
            this.txtBilgi.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtBilgi);
            this.Controls.Add(this.btnBilgi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBilgi;
        private System.Windows.Forms.TextBox txtBilgi;
    }
}

