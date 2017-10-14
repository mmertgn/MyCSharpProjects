namespace wf_CokBoyutlu
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
            this.lbOgrenciler = new System.Windows.Forms.ListBox();
            this.lbNotlar1 = new System.Windows.Forms.ListBox();
            this.lbNotlar2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbOgrenciler
            // 
            this.lbOgrenciler.FormattingEnabled = true;
            this.lbOgrenciler.ItemHeight = 20;
            this.lbOgrenciler.Location = new System.Drawing.Point(62, 49);
            this.lbOgrenciler.Name = "lbOgrenciler";
            this.lbOgrenciler.Size = new System.Drawing.Size(137, 204);
            this.lbOgrenciler.TabIndex = 0;
            this.lbOgrenciler.SelectedIndexChanged += new System.EventHandler(this.lbOgrenciler_SelectedIndexChanged);
            // 
            // lbNotlar1
            // 
            this.lbNotlar1.FormattingEnabled = true;
            this.lbNotlar1.ItemHeight = 20;
            this.lbNotlar1.Location = new System.Drawing.Point(228, 49);
            this.lbNotlar1.Name = "lbNotlar1";
            this.lbNotlar1.Size = new System.Drawing.Size(137, 204);
            this.lbNotlar1.TabIndex = 1;
            this.lbNotlar1.SelectedIndexChanged += new System.EventHandler(this.lbNotlar1_SelectedIndexChanged);
            // 
            // lbNotlar2
            // 
            this.lbNotlar2.FormattingEnabled = true;
            this.lbNotlar2.ItemHeight = 20;
            this.lbNotlar2.Location = new System.Drawing.Point(394, 49);
            this.lbNotlar2.Name = "lbNotlar2";
            this.lbNotlar2.Size = new System.Drawing.Size(137, 204);
            this.lbNotlar2.TabIndex = 2;
            this.lbNotlar2.SelectedIndexChanged += new System.EventHandler(this.lbNotlar2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 408);
            this.Controls.Add(this.lbNotlar2);
            this.Controls.Add(this.lbNotlar1);
            this.Controls.Add(this.lbOgrenciler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbOgrenciler;
        private System.Windows.Forms.ListBox lbNotlar1;
        private System.Windows.Forms.ListBox lbNotlar2;
    }
}

