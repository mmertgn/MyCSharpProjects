namespace wf_PiSayisi
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtYariCap = new System.Windows.Forms.TextBox();
            this.btnCevre = new System.Windows.Forms.Button();
            this.btnAlan = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.rbCevre = new System.Windows.Forms.RadioButton();
            this.rbAlan = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yarıçap";
            // 
            // txtYariCap
            // 
            this.txtYariCap.Location = new System.Drawing.Point(62, 27);
            this.txtYariCap.Name = "txtYariCap";
            this.txtYariCap.Size = new System.Drawing.Size(157, 20);
            this.txtYariCap.TabIndex = 1;
            // 
            // btnCevre
            // 
            this.btnCevre.Location = new System.Drawing.Point(62, 153);
            this.btnCevre.Name = "btnCevre";
            this.btnCevre.Size = new System.Drawing.Size(75, 23);
            this.btnCevre.TabIndex = 6;
            this.btnCevre.Text = "Çevre";
            this.btnCevre.UseVisualStyleBackColor = true;
            this.btnCevre.Visible = false;
            this.btnCevre.Click += new System.EventHandler(this.btnCevre_Click);
            // 
            // btnAlan
            // 
            this.btnAlan.Location = new System.Drawing.Point(144, 153);
            this.btnAlan.Name = "btnAlan";
            this.btnAlan.Size = new System.Drawing.Size(75, 23);
            this.btnAlan.TabIndex = 7;
            this.btnAlan.Text = "Alan";
            this.btnAlan.UseVisualStyleBackColor = true;
            this.btnAlan.Visible = false;
            this.btnAlan.Click += new System.EventHandler(this.btnAlan_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(62, 54);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // rbCevre
            // 
            this.rbCevre.AutoSize = true;
            this.rbCevre.Checked = true;
            this.rbCevre.Location = new System.Drawing.Point(16, 94);
            this.rbCevre.Name = "rbCevre";
            this.rbCevre.Size = new System.Drawing.Size(102, 17);
            this.rbCevre.TabIndex = 9;
            this.rbCevre.TabStop = true;
            this.rbCevre.Text = "Dairenin Çevresi";
            this.rbCevre.UseVisualStyleBackColor = true;
            // 
            // rbAlan
            // 
            this.rbAlan.AutoSize = true;
            this.rbAlan.Location = new System.Drawing.Point(129, 94);
            this.rbAlan.Name = "rbAlan";
            this.rbAlan.Size = new System.Drawing.Size(90, 17);
            this.rbAlan.TabIndex = 10;
            this.rbAlan.Text = "Dairenin Alanı";
            this.rbAlan.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 212);
            this.Controls.Add(this.rbAlan);
            this.Controls.Add(this.rbCevre);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.btnAlan);
            this.Controls.Add(this.btnCevre);
            this.Controls.Add(this.txtYariCap);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYariCap;
        private System.Windows.Forms.Button btnCevre;
        private System.Windows.Forms.Button btnAlan;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.RadioButton rbCevre;
        private System.Windows.Forms.RadioButton rbAlan;
    }
}

