namespace wf_Methods
{
    partial class Form3
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
            this.lbListe1 = new System.Windows.Forms.ListBox();
            this.lbListe2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbListe1
            // 
            this.lbListe1.FormattingEnabled = true;
            this.lbListe1.ItemHeight = 20;
            this.lbListe1.Location = new System.Drawing.Point(89, 71);
            this.lbListe1.Name = "lbListe1";
            this.lbListe1.Size = new System.Drawing.Size(130, 164);
            this.lbListe1.TabIndex = 0;
            // 
            // lbListe2
            // 
            this.lbListe2.FormattingEnabled = true;
            this.lbListe2.ItemHeight = 20;
            this.lbListe2.Location = new System.Drawing.Point(273, 71);
            this.lbListe2.Name = "lbListe2";
            this.lbListe2.Size = new System.Drawing.Size(130, 164);
            this.lbListe2.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 361);
            this.Controls.Add(this.lbListe2);
            this.Controls.Add(this.lbListe1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbListe1;
        private System.Windows.Forms.ListBox lbListe2;
    }
}