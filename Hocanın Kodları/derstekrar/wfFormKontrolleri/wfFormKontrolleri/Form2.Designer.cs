namespace wfFormKontrolleri
{
    partial class Form2
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
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.lblSayi2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.rbTopla = new System.Windows.Forms.RadioButton();
            this.rbCikar = new System.Windows.Forms.RadioButton();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSayi1
            // 
            this.lblSayi1.AutoSize = true;
            this.lblSayi1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSayi1.Location = new System.Drawing.Point(99, 66);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(36, 13);
            this.lblSayi1.TabIndex = 0;
            this.lblSayi1.Text = "Sayı 1";
            // 
            // lblSayi2
            // 
            this.lblSayi2.AutoSize = true;
            this.lblSayi2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSayi2.Location = new System.Drawing.Point(99, 91);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(36, 13);
            this.lblSayi2.TabIndex = 1;
            this.lblSayi2.Text = "Sayı 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(171, 121);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(38, 13);
            this.lblSonuc.TabIndex = 3;
            this.lblSonuc.Text = "Sonuç";
            // 
            // rbTopla
            // 
            this.rbTopla.AutoSize = true;
            this.rbTopla.Checked = true;
            this.rbTopla.Location = new System.Drawing.Point(102, 155);
            this.rbTopla.Name = "rbTopla";
            this.rbTopla.Size = new System.Drawing.Size(52, 17);
            this.rbTopla.TabIndex = 4;
            this.rbTopla.TabStop = true;
            this.rbTopla.Text = "Topla";
            this.rbTopla.UseVisualStyleBackColor = true;
            // 
            // rbCikar
            // 
            this.rbCikar.AutoSize = true;
            this.rbCikar.Location = new System.Drawing.Point(102, 178);
            this.rbCikar.Name = "rbCikar";
            this.rbCikar.Size = new System.Drawing.Size(49, 17);
            this.rbCikar.TabIndex = 4;
            this.rbCikar.TabStop = true;
            this.rbCikar.Text = "Çıkar";
            this.rbCikar.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(102, 211);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(193, 211);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 343);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.rbCikar);
            this.Controls.Add(this.rbTopla);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSayi2);
            this.Controls.Add(this.lblSayi1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.Label lblSayi2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.RadioButton rbTopla;
        private System.Windows.Forms.RadioButton rbCikar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnCikis;
    }
}