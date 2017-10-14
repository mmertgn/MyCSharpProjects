namespace wf_CokBoyutlu
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
            this.lbOrtalamalar = new System.Windows.Forms.ListBox();
            this.lbOgrenciler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbOrtalamalar
            // 
            this.lbOrtalamalar.FormattingEnabled = true;
            this.lbOrtalamalar.ItemHeight = 20;
            this.lbOrtalamalar.Location = new System.Drawing.Point(325, 81);
            this.lbOrtalamalar.Name = "lbOrtalamalar";
            this.lbOrtalamalar.Size = new System.Drawing.Size(99, 184);
            this.lbOrtalamalar.TabIndex = 3;
            // 
            // lbOgrenciler
            // 
            this.lbOgrenciler.FormattingEnabled = true;
            this.lbOgrenciler.ItemHeight = 20;
            this.lbOgrenciler.Location = new System.Drawing.Point(104, 81);
            this.lbOgrenciler.Name = "lbOgrenciler";
            this.lbOgrenciler.Size = new System.Drawing.Size(141, 184);
            this.lbOgrenciler.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Öğrenciler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ortalamalar";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 391);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbOrtalamalar);
            this.Controls.Add(this.lbOgrenciler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbOrtalamalar;
        private System.Windows.Forms.ListBox lbOgrenciler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}