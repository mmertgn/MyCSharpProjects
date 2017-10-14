namespace wf_Methods
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
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOrtalamaBul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.Sayı";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(109, 122);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(61, 26);
            this.txtSayi1.TabIndex = 1;
            this.txtSayi1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(258, 122);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(61, 26);
            this.txtSayi2.TabIndex = 3;
            this.txtSayi2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "2.Sayı";
            // 
            // btnOrtalamaBul
            // 
            this.btnOrtalamaBul.Location = new System.Drawing.Point(167, 187);
            this.btnOrtalamaBul.Name = "btnOrtalamaBul";
            this.btnOrtalamaBul.Size = new System.Drawing.Size(98, 49);
            this.btnOrtalamaBul.TabIndex = 4;
            this.btnOrtalamaBul.Text = "Ortalama Bul";
            this.btnOrtalamaBul.UseVisualStyleBackColor = true;
            this.btnOrtalamaBul.Click += new System.EventHandler(this.btnOrtalamaBul_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.btnOrtalamaBul);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOrtalamaBul;
    }
}