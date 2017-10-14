namespace wf_ListboxVeListview
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
            this.lbSayilar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbSayilar
            // 
            this.lbSayilar.FormattingEnabled = true;
            this.lbSayilar.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.lbSayilar.Location = new System.Drawing.Point(79, 47);
            this.lbSayilar.Name = "lbSayilar";
            this.lbSayilar.Size = new System.Drawing.Size(129, 186);
            this.lbSayilar.TabIndex = 0;
            this.lbSayilar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbSayilar_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 338);
            this.Controls.Add(this.lbSayilar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbSayilar;
    }
}

