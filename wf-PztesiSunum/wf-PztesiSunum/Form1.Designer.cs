namespace wf_PztesiSunum
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
            this.lbAdlar = new System.Windows.Forms.ListBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAdlar
            // 
            this.lbAdlar.FormattingEnabled = true;
            this.lbAdlar.ItemHeight = 20;
            this.lbAdlar.Items.AddRange(new object[] {
            "Mert",
            "Ali",
            "Veli"});
            this.lbAdlar.Location = new System.Drawing.Point(207, 36);
            this.lbAdlar.Name = "lbAdlar";
            this.lbAdlar.Size = new System.Drawing.Size(144, 184);
            this.lbAdlar.TabIndex = 0;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(101, 36);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 26);
            this.txtAd.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(101, 68);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 26);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 383);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lbAdlar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAdlar;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnEkle;
    }
}

