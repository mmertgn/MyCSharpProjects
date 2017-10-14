namespace form_kontrolleri
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.rbTopla = new System.Windows.Forms.RadioButton();
            this.rbCikar = new System.Windows.Forms.RadioButton();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sayı 2";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(149, 64);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 22);
            this.txtSayi1.TabIndex = 2;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(149, 121);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 22);
            this.txtSayi2.TabIndex = 3;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(171, 173);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(48, 17);
            this.lblSonuc.TabIndex = 4;
            this.lblSonuc.Text = "Sonuç";
            // 
            // rbTopla
            // 
            this.rbTopla.AutoSize = true;
            this.rbTopla.Location = new System.Drawing.Point(67, 227);
            this.rbTopla.Name = "rbTopla";
            this.rbTopla.Size = new System.Drawing.Size(65, 21);
            this.rbTopla.TabIndex = 5;
            this.rbTopla.TabStop = true;
            this.rbTopla.Text = "Topla";
            this.rbTopla.UseVisualStyleBackColor = true;
            // 
            // rbCikar
            // 
            this.rbCikar.AutoSize = true;
            this.rbCikar.Location = new System.Drawing.Point(67, 270);
            this.rbCikar.Name = "rbCikar";
            this.rbCikar.Size = new System.Drawing.Size(61, 21);
            this.rbCikar.TabIndex = 6;
            this.rbCikar.TabStop = true;
            this.rbCikar.Text = "Çıkar";
            this.rbCikar.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(66, 320);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 33);
            this.btnHesapla.TabIndex = 7;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(193, 320);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 33);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 443);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.rbCikar);
            this.Controls.Add(this.rbTopla);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.RadioButton rbTopla;
        private System.Windows.Forms.RadioButton rbCikar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnCikis;
    }
}