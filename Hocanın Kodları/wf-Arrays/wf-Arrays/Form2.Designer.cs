namespace wf_Arrays
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
            this.btnYukle = new System.Windows.Forms.Button();
            this.lbOgrenciler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnYukle
            // 
            this.btnYukle.Location = new System.Drawing.Point(142, 50);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(136, 35);
            this.btnYukle.TabIndex = 0;
            this.btnYukle.Text = "Yükle";
            this.btnYukle.UseVisualStyleBackColor = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // lbOgrenciler
            // 
            this.lbOgrenciler.FormattingEnabled = true;
            this.lbOgrenciler.ItemHeight = 20;
            this.lbOgrenciler.Location = new System.Drawing.Point(122, 107);
            this.lbOgrenciler.Name = "lbOgrenciler";
            this.lbOgrenciler.Size = new System.Drawing.Size(175, 224);
            this.lbOgrenciler.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 434);
            this.Controls.Add(this.lbOgrenciler);
            this.Controls.Add(this.btnYukle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.ListBox lbOgrenciler;
    }
}