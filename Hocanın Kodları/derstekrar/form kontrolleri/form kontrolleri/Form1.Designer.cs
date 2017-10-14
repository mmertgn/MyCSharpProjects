namespace form_kontrolleri
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
            this.btnAc = new System.Windows.Forms.Button();
            this.txtBilgi = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAc
            // 
            this.btnAc.Location = new System.Drawing.Point(215, 246);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(75, 57);
            this.btnAc.TabIndex = 0;
            this.btnAc.Text = "Mesajı Oku";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // txtBilgi
            // 
            this.txtBilgi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBilgi.Location = new System.Drawing.Point(98, 125);
            this.txtBilgi.Multiline = true;
            this.txtBilgi.Name = "txtBilgi";
            this.txtBilgi.ReadOnly = true;
            this.txtBilgi.Size = new System.Drawing.Size(335, 95);
            this.txtBilgi.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(215, 328);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 34);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 535);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.txtBilgi);
            this.Controls.Add(this.btnAc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.TextBox txtBilgi;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnKapat;
    }
}

