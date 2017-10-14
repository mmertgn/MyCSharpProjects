namespace wf_ListView
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
            this.lvOzellikler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.cbMarkalar = new System.Windows.Forms.ComboBox();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mitmLargeIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmSmallIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmList = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmTile = new System.Windows.Forms.ToolStripMenuItem();
            this.ilSmall = new System.Windows.Forms.ImageList(this.components);
            this.ilLarge = new System.Windows.Forms.ImageList(this.components);
            this.cmView.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvOzellikler
            // 
            this.lvOzellikler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvOzellikler.ContextMenuStrip = this.cmView;
            this.lvOzellikler.FullRowSelect = true;
            this.lvOzellikler.GridLines = true;
            this.lvOzellikler.LargeImageList = this.ilLarge;
            this.lvOzellikler.Location = new System.Drawing.Point(89, 127);
            this.lvOzellikler.Name = "lvOzellikler";
            this.lvOzellikler.Size = new System.Drawing.Size(634, 219);
            this.lvOzellikler.SmallImageList = this.ilSmall;
            this.lvOzellikler.TabIndex = 9;
            this.lvOzellikler.UseCompatibleStateImageBehavior = false;
            this.lvOzellikler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İşlemci";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hafıza(Ram)";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ekran";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kamera";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fiyat";
            this.columnHeader5.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Marka Seçiniz";
            // 
            // cbMarkalar
            // 
            this.cbMarkalar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarkalar.FormattingEnabled = true;
            this.cbMarkalar.Items.AddRange(new object[] {
            "Apple",
            "Samsung",
            "Nokia"});
            this.cbMarkalar.Location = new System.Drawing.Point(89, 84);
            this.cbMarkalar.Name = "cbMarkalar";
            this.cbMarkalar.Size = new System.Drawing.Size(135, 28);
            this.cbMarkalar.TabIndex = 7;
            this.cbMarkalar.SelectedIndexChanged += new System.EventHandler(this.cbMarkalar_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Model";
            this.columnHeader6.Width = 130;
            // 
            // cmView
            // 
            this.cmView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmLargeIcon,
            this.mitmDetails,
            this.mitmSmallIcon,
            this.mitmList,
            this.mitmTile});
            this.cmView.Name = "cmView";
            this.cmView.Size = new System.Drawing.Size(153, 134);
            // 
            // mitmLargeIcon
            // 
            this.mitmLargeIcon.Name = "mitmLargeIcon";
            this.mitmLargeIcon.Size = new System.Drawing.Size(152, 26);
            this.mitmLargeIcon.Text = "Large Icon";
            this.mitmLargeIcon.Click += new System.EventHandler(this.mitmLargeIcon_Click);
            // 
            // mitmDetails
            // 
            this.mitmDetails.Name = "mitmDetails";
            this.mitmDetails.Size = new System.Drawing.Size(152, 26);
            this.mitmDetails.Text = "Details";
            this.mitmDetails.Click += new System.EventHandler(this.mitmDetails_Click);
            // 
            // mitmSmallIcon
            // 
            this.mitmSmallIcon.Name = "mitmSmallIcon";
            this.mitmSmallIcon.Size = new System.Drawing.Size(152, 26);
            this.mitmSmallIcon.Text = "Small Icon";
            this.mitmSmallIcon.Click += new System.EventHandler(this.mitmSmallIcon_Click);
            // 
            // mitmList
            // 
            this.mitmList.Name = "mitmList";
            this.mitmList.Size = new System.Drawing.Size(152, 26);
            this.mitmList.Text = "List";
            this.mitmList.Click += new System.EventHandler(this.mitmList_Click);
            // 
            // mitmTile
            // 
            this.mitmTile.Name = "mitmTile";
            this.mitmTile.Size = new System.Drawing.Size(152, 26);
            this.mitmTile.Text = "Tile";
            this.mitmTile.Click += new System.EventHandler(this.mitmTile_Click);
            // 
            // ilSmall
            // 
            this.ilSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilSmall.ImageStream")));
            this.ilSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.ilSmall.Images.SetKeyName(0, "resim1.jpg");
            this.ilSmall.Images.SetKeyName(1, "resim2.jpg");
            this.ilSmall.Images.SetKeyName(2, "resim3.png");
            // 
            // ilLarge
            // 
            this.ilLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilLarge.ImageStream")));
            this.ilLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.ilLarge.Images.SetKeyName(0, "resim1.jpg");
            this.ilLarge.Images.SetKeyName(1, "resim2.jpg");
            this.ilLarge.Images.SetKeyName(2, "resim3.png");
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.lvOzellikler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMarkalar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.cmView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvOzellikler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMarkalar;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ContextMenuStrip cmView;
        private System.Windows.Forms.ToolStripMenuItem mitmLargeIcon;
        private System.Windows.Forms.ToolStripMenuItem mitmDetails;
        private System.Windows.Forms.ToolStripMenuItem mitmSmallIcon;
        private System.Windows.Forms.ToolStripMenuItem mitmList;
        private System.Windows.Forms.ToolStripMenuItem mitmTile;
        private System.Windows.Forms.ImageList ilLarge;
        private System.Windows.Forms.ImageList ilSmall;
    }
}