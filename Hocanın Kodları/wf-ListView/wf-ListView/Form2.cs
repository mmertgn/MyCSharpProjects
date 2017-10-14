using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_ListView
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void cbMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvOzellikler.Items.Clear();
            if (cbMarkalar.SelectedItem.ToString() == "Apple")
            {
                lvOzellikler.Items.Add("IPhone 6", 0);
                lvOzellikler.Items[0].SubItems.Add("1,4 GHz");
                lvOzellikler.Items[0].SubItems.Add("1 GB");
                lvOzellikler.Items[0].SubItems.Add("4,7 inch");
                lvOzellikler.Items[0].SubItems.Add("8 MP");
                lvOzellikler.Items[0].SubItems.Add("2000");

                lvOzellikler.Items.Add("IPhone 7", 1);
                lvOzellikler.Items[1].SubItems.Add("1,6 GHz");
                lvOzellikler.Items[1].SubItems.Add("2 GB");
                lvOzellikler.Items[1].SubItems.Add("5,1 inch");
                lvOzellikler.Items[1].SubItems.Add("10 MP");
                lvOzellikler.Items[1].SubItems.Add("2600");

                lvOzellikler.Items.Add("IPhone 8", 2);
                lvOzellikler.Items[2].SubItems.Add("2,3 GHz");
                lvOzellikler.Items[2].SubItems.Add("3 GB");
                lvOzellikler.Items[2].SubItems.Add("4,7 inch");
                lvOzellikler.Items[2].SubItems.Add("12 MP");
                lvOzellikler.Items[2].SubItems.Add("4000");
            }
            else if (cbMarkalar.SelectedItem.ToString() == "Samsung")
            {
                lvOzellikler.Items.Add("Galaxy S7", 0);
                lvOzellikler.Items[0].SubItems.Add("1,4 GHz");
                lvOzellikler.Items[0].SubItems.Add("2 GB");
                lvOzellikler.Items[0].SubItems.Add("5,1 inch");
                lvOzellikler.Items[0].SubItems.Add("8 MP");
                lvOzellikler.Items[0].SubItems.Add("2600");

                lvOzellikler.Items.Add("Galaxy S7 Edge", 1);
                lvOzellikler.Items[1].SubItems.Add("1,6 GHz");
                lvOzellikler.Items[1].SubItems.Add("2 GB");
                lvOzellikler.Items[1].SubItems.Add("5,5 inch");
                lvOzellikler.Items[1].SubItems.Add("10 MP");
                lvOzellikler.Items[1].SubItems.Add("2900");

                lvOzellikler.Items.Add("Galaxy S8", 2);
                lvOzellikler.Items[2].SubItems.Add("2,3 GHz");
                lvOzellikler.Items[2].SubItems.Add("3 GB");
                lvOzellikler.Items[2].SubItems.Add("4,7 inch");
                lvOzellikler.Items[2].SubItems.Add("12 MP");
                lvOzellikler.Items[2].SubItems.Add("3300");
            }

        }
        private void mitmLargeIcon_Click(object sender, EventArgs e)
        {
            lvOzellikler.View = View.LargeIcon;
        }
        private void mitmDetails_Click(object sender, EventArgs e)
        {
            lvOzellikler.View = View.Details;
        }
        private void mitmSmallIcon_Click(object sender, EventArgs e)
        {
            lvOzellikler.View = View.SmallIcon;
        }
        private void mitmList_Click(object sender, EventArgs e)
        {
            lvOzellikler.View = View.List;
        }
        private void mitmTile_Click(object sender, EventArgs e)
        {
            lvOzellikler.View = View.Tile;
        }
    }
}
