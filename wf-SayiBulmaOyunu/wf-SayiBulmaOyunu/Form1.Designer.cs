namespace wf_SayiBulmaOyunu
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.btnDene = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGameOver = new System.Windows.Forms.Button();
            this.rbBaslangic = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbIleri = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "1-50 arasında bir sayı tuttum. Bakalım kaç defada bulabileceksin?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tahmininiz";
            // 
            // txtTahmin
            // 
            this.txtTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTahmin.Location = new System.Drawing.Point(100, 112);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(100, 26);
            this.txtTahmin.TabIndex = 2;
            this.txtTahmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDene
            // 
            this.btnDene.Location = new System.Drawing.Point(206, 112);
            this.btnDene.Name = "btnDene";
            this.btnDene.Size = new System.Drawing.Size(75, 26);
            this.btnDene.TabIndex = 3;
            this.btnDene.Text = "Dene";
            this.btnDene.UseVisualStyleBackColor = true;
            this.btnDene.Click += new System.EventHandler(this.btnDene_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(12, 229);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 61);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGameOver
            // 
            this.btnGameOver.Location = new System.Drawing.Point(566, 229);
            this.btnGameOver.Name = "btnGameOver";
            this.btnGameOver.Size = new System.Drawing.Size(75, 61);
            this.btnGameOver.TabIndex = 5;
            this.btnGameOver.Text = "GAME OVER";
            this.btnGameOver.UseVisualStyleBackColor = true;
            this.btnGameOver.Click += new System.EventHandler(this.btnGameOver_Click);
            // 
            // rbBaslangic
            // 
            this.rbBaslangic.AutoSize = true;
            this.rbBaslangic.Checked = true;
            this.rbBaslangic.Location = new System.Drawing.Point(104, 48);
            this.rbBaslangic.Name = "rbBaslangic";
            this.rbBaslangic.Size = new System.Drawing.Size(96, 24);
            this.rbBaslangic.TabIndex = 6;
            this.rbBaslangic.TabStop = true;
            this.rbBaslangic.Text = "Başlangıç";
            this.rbBaslangic.UseVisualStyleBackColor = true;
            this.rbBaslangic.CheckedChanged += new System.EventHandler(this.rbBaslangic_CheckedChanged);
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(206, 48);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(108, 24);
            this.rbOrta.TabIndex = 7;
            this.rbOrta.Tag = "";
            this.rbOrta.Text = "Orta Seviye";
            this.rbOrta.UseVisualStyleBackColor = true;
            this.rbOrta.CheckedChanged += new System.EventHandler(this.rbOrta_CheckedChanged);
            // 
            // rbIleri
            // 
            this.rbIleri.AutoSize = true;
            this.rbIleri.Location = new System.Drawing.Point(320, 48);
            this.rbIleri.Name = "rbIleri";
            this.rbIleri.Size = new System.Drawing.Size(102, 24);
            this.rbIleri.TabIndex = 8;
            this.rbIleri.Text = "İleri Seviye";
            this.rbIleri.UseVisualStyleBackColor = true;
            this.rbIleri.CheckedChanged += new System.EventHandler(this.rbIleri_CheckedChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDene;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(653, 302);
            this.ControlBox = false;
            this.Controls.Add(this.rbIleri);
            this.Controls.Add(this.rbOrta);
            this.Controls.Add(this.rbBaslangic);
            this.Controls.Add(this.btnGameOver);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDene);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Sayı Bulma Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Button btnDene;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGameOver;
        private System.Windows.Forms.RadioButton rbBaslangic;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbIleri;
    }
}

