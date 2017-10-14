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
            if (cbMarkalar.Text == "Apple")
            {
                lvOzellikler.Items.Add("İphone 6",0);
                lvOzellikler.Items[0].SubItems.Add("1.5 GHz");
                lvOzellikler.Items[0].SubItems.Add("3 GB");
                lvOzellikler.Items[0].SubItems.Add("4.7\"");
                lvOzellikler.Items[0].SubItems.Add("16 MP");
                lvOzellikler.Items[0].SubItems.Add("2250");

                lvOzellikler.Items.Add("İphone 7",1);
                lvOzellikler.Items[1].SubItems.Add("1.6 GHz");
                lvOzellikler.Items[1].SubItems.Add("4 GB");
                lvOzellikler.Items[1].SubItems.Add("5.1\"");
                lvOzellikler.Items[1].SubItems.Add("16 MP");
                lvOzellikler.Items[1].SubItems.Add("2500");

                lvOzellikler.Items.Add("İphone 8",2);
                lvOzellikler.Items[2].SubItems.Add("1.7 GHz");
                lvOzellikler.Items[2].SubItems.Add("6 GB");
                lvOzellikler.Items[2].SubItems.Add("5.5\"");
                lvOzellikler.Items[2].SubItems.Add("16 MP");
                lvOzellikler.Items[2].SubItems.Add("3000");
            }
            else if (cbMarkalar.Text == "Samsung")
            {
                lvOzellikler.Items.Add("Galaxy S6" , 4);
                lvOzellikler.Items[0].SubItems.Add("1.5 GHz");
                lvOzellikler.Items[0].SubItems.Add("3 GB");
                lvOzellikler.Items[0].SubItems.Add("4.7\"");
                lvOzellikler.Items[0].SubItems.Add("16 MP");
                lvOzellikler.Items[0].SubItems.Add("2250 TL");

                lvOzellikler.Items.Add("Galaxy S7", 3);
                lvOzellikler.Items[1].SubItems.Add("1.6 GHz");
                lvOzellikler.Items[1].SubItems.Add("4 GB");
                lvOzellikler.Items[1].SubItems.Add("5.1\"");
                lvOzellikler.Items[1].SubItems.Add("16 MP");
                lvOzellikler.Items[1].SubItems.Add("2500 TL");

                lvOzellikler.Items.Add("Galaxy S8");
                lvOzellikler.Items[2].SubItems.Add("1.7 GHz");
                lvOzellikler.Items[2].SubItems.Add("6 GB");
                lvOzellikler.Items[2].SubItems.Add("5.5\"");
                lvOzellikler.Items[2].SubItems.Add("16 MP");
                lvOzellikler.Items[2].SubItems.Add("3000 TL");
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

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam=0;
            for (int i = 0; i < lvOzellikler.Items.Count; i++)
            {
                toplam += Convert.ToInt32(lvOzellikler.Items[i].SubItems[5].Text);
            }
            MessageBox.Show("Toplam : " + toplam);
        }
    }
}
