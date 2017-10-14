namespace wf_PztesiSunum
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lbMarkalar = new System.Windows.Forms.ListBox();
            this.lvUrunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvSepet = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.txtSepetToplam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ilUrunler = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMarkalar
            // 
            this.lbMarkalar.FormattingEnabled = true;
            this.lbMarkalar.Location = new System.Drawing.Point(58, 48);
            this.lbMarkalar.Name = "lbMarkalar";
            this.lbMarkalar.Size = new System.Drawing.Size(120, 95);
            this.lbMarkalar.TabIndex = 0;
            this.lbMarkalar.SelectedIndexChanged += new System.EventHandler(this.lbUrunler_SelectedIndexChanged);
            // 
            // lvUrunler
            // 
            this.lvUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvUrunler.FullRowSelect = true;
            this.lvUrunler.GridLines = true;
            this.lvUrunler.LargeImageList = this.ilUrunler;
            this.lvUrunler.Location = new System.Drawing.Point(184, 22);
            this.lvUrunler.Name = "lvUrunler";
            this.lvUrunler.Size = new System.Drawing.Size(331, 233);
            this.lvUrunler.TabIndex = 1;
            this.lvUrunler.UseCompatibleStateImageBehavior = false;
            this.lvUrunler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 74;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fiyatı";
            this.columnHeader2.Width = 85;
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Items.AddRange(new object[] {
            "İşlemci",
            "RAM",
            "Ekran Kartı",
            "SSD"});
            this.cbKategori.Location = new System.Drawing.Point(58, 21);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(121, 21);
            this.cbKategori.TabIndex = 2;
            this.cbKategori.SelectedIndexChanged += new System.EventHandler(this.CbKategori_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kategori";
            // 
            // lvSepet
            // 
            this.lvSepet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvSepet.LargeImageList = this.ilUrunler;
            this.lvSepet.Location = new System.Drawing.Point(521, 24);
            this.lvSepet.Name = "lvSepet";
            this.lvSepet.Size = new System.Drawing.Size(194, 231);
            this.lvSepet.TabIndex = 4;
            this.lvSepet.UseCompatibleStateImageBehavior = false;
            this.lvSepet.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sepet";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün Adı";
            this.columnHeader3.Width = 68;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ürün Fiyatı";
            this.columnHeader4.Width = 83;
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(440, 261);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(75, 23);
            this.btnSepeteEkle.TabIndex = 6;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // txtSepetToplam
            // 
            this.txtSepetToplam.Location = new System.Drawing.Point(615, 261);
            this.txtSepetToplam.Name = "txtSepetToplam";
            this.txtSepetToplam.ReadOnly = true;
            this.txtSepetToplam.Size = new System.Drawing.Size(100, 20);
            this.txtSepetToplam.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sepet Tutarı";
            // 
            // ilUrunler
            // 
            this.ilUrunler.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilUrunler.ImageStream")));
            this.ilUrunler.TransparentColor = System.Drawing.Color.Transparent;
            this.ilUrunler.Images.SetKeyName(0, "i3.jpg");
            this.ilUrunler.Images.SetKeyName(1, "i5.jpg");
            this.ilUrunler.Images.SetKeyName(2, "i7.jpg");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detayToolStripMenuItem,
            this.resimToolStripMenuItem,
            this.listeToolStripMenuItem,
            this.tileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(107, 92);
            // 
            // detayToolStripMenuItem
            // 
            this.detayToolStripMenuItem.Name = "detayToolStripMenuItem";
            this.detayToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.detayToolStripMenuItem.Text = "detay";
            this.detayToolStripMenuItem.Click += new System.EventHandler(this.detayToolStripMenuItem_Click);
            // 
            // resimToolStripMenuItem
            // 
            this.resimToolStripMenuItem.Name = "resimToolStripMenuItem";
            this.resimToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.resimToolStripMenuItem.Text = "Resim";
            this.resimToolStripMenuItem.Click += new System.EventHandler(this.resimToolStripMenuItem_Click);
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.listeToolStripMenuItem.Text = "Liste";
            this.listeToolStripMenuItem.Click += new System.EventHandler(this.listeToolStripMenuItem_Click);
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.tileToolStripMenuItem.Text = "Tile";
            this.tileToolStripMenuItem.Click += new System.EventHandler(this.tileToolStripMenuItem_Click);
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.Location = new System.Drawing.Point(640, 287);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(75, 23);
            this.btnSatinAl.TabIndex = 10;
            this.btnSatinAl.Text = "Satın Al";
            this.btnSatinAl.UseVisualStyleBackColor = true;
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 326);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnSatinAl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSepetToplam);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvSepet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.lvUrunler);
            this.Controls.Add(this.lbMarkalar);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "PC Toplama Sihirbazı";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMarkalar;
        private System.Windows.Forms.ListView lvUrunler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvSepet;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.TextBox txtSepetToplam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList ilUrunler;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem detayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileToolStripMenuItem;
        private System.Windows.Forms.Button btnSatinAl;
    }
}