namespace wf_ComboBox
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
            this.cbMarkalar = new System.Windows.Forms.ComboBox();
            this.lbModeller = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbMarkalar
            // 
            this.cbMarkalar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarkalar.FormattingEnabled = true;
            this.cbMarkalar.Items.AddRange(new object[] {
            "Apple",
            "Samsung",
            "Nokia"});
            this.cbMarkalar.Location = new System.Drawing.Point(171, 90);
            this.cbMarkalar.Name = "cbMarkalar";
            this.cbMarkalar.Size = new System.Drawing.Size(180, 28);
            this.cbMarkalar.TabIndex = 0;
            this.cbMarkalar.SelectedIndexChanged += new System.EventHandler(this.cbMarkalar_SelectedIndexChanged);
            // 
            // lbModeller
            // 
            this.lbModeller.FormattingEnabled = true;
            this.lbModeller.ItemHeight = 20;
            this.lbModeller.Location = new System.Drawing.Point(171, 125);
            this.lbModeller.Name = "lbModeller";
            this.lbModeller.Size = new System.Drawing.Size(180, 184);
            this.lbModeller.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marka Seçiniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbModeller);
            this.Controls.Add(this.cbMarkalar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMarkalar;
        private System.Windows.Forms.ListBox lbModeller;
        private System.Windows.Forms.Label label1;
    }
}

