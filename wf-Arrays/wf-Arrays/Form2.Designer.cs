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
            this.btnYukleFor = new System.Windows.Forms.Button();
            this.lbOgrenciler = new System.Windows.Forms.ListBox();
            this.btnYukleForeach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYukleFor
            // 
            this.btnYukleFor.Location = new System.Drawing.Point(103, 102);
            this.btnYukleFor.Name = "btnYukleFor";
            this.btnYukleFor.Size = new System.Drawing.Size(99, 41);
            this.btnYukleFor.TabIndex = 0;
            this.btnYukleFor.Text = "Yükle For";
            this.btnYukleFor.UseVisualStyleBackColor = true;
            this.btnYukleFor.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // lbOgrenciler
            // 
            this.lbOgrenciler.FormattingEnabled = true;
            this.lbOgrenciler.ItemHeight = 20;
            this.lbOgrenciler.Location = new System.Drawing.Point(117, 149);
            this.lbOgrenciler.Name = "lbOgrenciler";
            this.lbOgrenciler.Size = new System.Drawing.Size(199, 164);
            this.lbOgrenciler.TabIndex = 1;
            // 
            // btnYukleForeach
            // 
            this.btnYukleForeach.Location = new System.Drawing.Point(208, 102);
            this.btnYukleForeach.Name = "btnYukleForeach";
            this.btnYukleForeach.Size = new System.Drawing.Size(133, 41);
            this.btnYukleForeach.TabIndex = 2;
            this.btnYukleForeach.Text = "Yükle Foreach";
            this.btnYukleForeach.UseVisualStyleBackColor = true;
            this.btnYukleForeach.Click += new System.EventHandler(this.btnYukleForeach_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.btnYukleForeach);
            this.Controls.Add(this.lbOgrenciler);
            this.Controls.Add(this.btnYukleFor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYukleFor;
        private System.Windows.Forms.ListBox lbOgrenciler;
        private System.Windows.Forms.Button btnYukleForeach;
    }
}