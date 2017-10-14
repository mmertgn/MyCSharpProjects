namespace wf_ListView
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
            this.lbModeller = new System.Windows.Forms.ListBox();
            this.cbMarkalar = new System.Windows.Forms.ComboBox();
            this.lvOzellikler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Marka Seçiniz";
            // 
            // lbModeller
            // 
            this.lbModeller.FormattingEnabled = true;
            this.lbModeller.Location = new System.Drawing.Point(46, 87);
            this.lbModeller.Name = "lbModeller";
            this.lbModeller.Size = new System.Drawing.Size(120, 95);
            this.lbModeller.TabIndex = 4;
            this.lbModeller.SelectedIndexChanged += new System.EventHandler(this.lbModeller_SelectedIndexChanged);
            // 
            // cbMarkalar
            // 
            this.cbMarkalar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarkalar.FormattingEnabled = true;
            this.cbMarkalar.Items.AddRange(new object[] {
            "Apple",
            "Samsung",
            "Nokia"});
            this.cbMarkalar.Location = new System.Drawing.Point(46, 60);
            this.cbMarkalar.Name = "cbMarkalar";
            this.cbMarkalar.Size = new System.Drawing.Size(121, 21);
            this.cbMarkalar.TabIndex = 3;
            this.cbMarkalar.SelectedIndexChanged += new System.EventHandler(this.cbMarkalar_SelectedIndexChanged);
            // 
            // lvOzellikler
            // 
            this.lvOzellikler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvOzellikler.Location = new System.Drawing.Point(173, 60);
            this.lvOzellikler.Name = "lvOzellikler";
            this.lvOzellikler.Size = new System.Drawing.Size(487, 122);
            this.lvOzellikler.TabIndex = 6;
            this.lvOzellikler.UseCompatibleStateImageBehavior = false;
            this.lvOzellikler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İşlemci";
            this.columnHeader1.Width = 52;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hafıza(Ram)";
            this.columnHeader2.Width = 87;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ekran";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kamera";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fiyat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 461);
            this.Controls.Add(this.lvOzellikler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbModeller);
            this.Controls.Add(this.cbMarkalar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbModeller;
        private System.Windows.Forms.ComboBox cbMarkalar;
        private System.Windows.Forms.ListView lvOzellikler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

