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
            this.txtYaricap = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(209, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yarıçap";
            // 
            // txtYaricap
            // 
            this.txtYaricap.Location = new System.Drawing.Point(202, 118);
            this.txtYaricap.Name = "txtYaricap";
            this.txtYaricap.Size = new System.Drawing.Size(79, 26);
            this.txtYaricap.TabIndex = 1;
            this.txtYaricap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCevre
            // 
            this.btnCevre.Location = new System.Drawing.Point(45, 277);
            this.btnCevre.Name = "btnCevre";
            this.btnCevre.Size = new System.Drawing.Size(78, 68);
            this.btnCevre.TabIndex = 2;
            this.btnCevre.Text = "Dairenin Çevresi";
            this.btnCevre.UseVisualStyleBackColor = true;
            this.btnCevre.Visible = false;
            this.btnCevre.Click += new System.EventHandler(this.btnCevre_Click);
            // 
            // btnAlan
            // 
            this.btnAlan.Location = new System.Drawing.Point(406, 277);
            this.btnAlan.Name = "btnAlan";
            this.btnAlan.Size = new System.Drawing.Size(78, 68);
            this.btnAlan.TabIndex = 3;
            this.btnAlan.Text = "Dairenin Alanı";
            this.btnAlan.UseVisualStyleBackColor = true;
            this.btnAlan.Visible = false;
            this.btnAlan.Click += new System.EventHandler(this.btnAlan_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(202, 174);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(79, 36);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // rbCevre
            // 
            this.rbCevre.AutoSize = true;
            this.rbCevre.Checked = true;
            this.rbCevre.Location = new System.Drawing.Point(62, 44);
            this.rbCevre.Name = "rbCevre";
            this.rbCevre.Size = new System.Drawing.Size(142, 24);
            this.rbCevre.TabIndex = 5;
            this.rbCevre.TabStop = true;
            this.rbCevre.Text = "Dairenin Çevresi";
            this.rbCevre.UseVisualStyleBackColor = true;
            // 
            // rbAlan
            // 
            this.rbAlan.AutoSize = true;
            this.rbAlan.Location = new System.Drawing.Point(342, 44);
            this.rbAlan.Name = "rbAlan";
            this.rbAlan.Size = new System.Drawing.Size(125, 24);
            this.rbAlan.TabIndex = 6;
            this.rbAlan.TabStop = true;
            this.rbAlan.Text = "Dairenin Alanı";
            this.rbAlan.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 404);
            this.Controls.Add(this.rbAlan);
            this.Controls.Add(this.rbCevre);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.btnAlan);
            this.Controls.Add(this.btnCevre);
            this.Controls.Add(this.txtYaricap);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYaricap;
        private System.Windows.Forms.Button btnCevre;
        private System.Windows.Forms.Button btnAlan;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.RadioButton rbCevre;
        private System.Windows.Forms.RadioButton rbAlan;
    }
}

