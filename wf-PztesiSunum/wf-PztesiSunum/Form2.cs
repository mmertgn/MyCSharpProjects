using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_PztesiSunum
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void CbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbMarkalar.Items.Clear();

            if (cbKategori.Text == "İşlemci")
            {
                lbMarkalar.Items.Add("INTEL");
                lbMarkalar.Items.Add("AMD");
            }
            else if (cbKategori.Text == "RAM")
            {
                lbMarkalar.Items.Add("DDR4");
                lbMarkalar.Items.Add("DDR3");
            }
            else if (cbKategori.Text == "Ekran Kartı")
            {
                lbMarkalar.Items.Add("Nvidia");
                lbMarkalar.Items.Add("AMD");
            }
            else if (cbKategori.Text == "SSD")
            {
                lbMarkalar.Items.Add("Samsung");
                lbMarkalar.Items.Add("Corsair");
            }
        }

        private void lbUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {

            lvUrunler.Items.Clear();
            if (lbMarkalar.SelectedItem.ToString() == "INTEL")
            {
                lvUrunler.Items.Add("i7 7700", 0);
                lvUrunler.Items[0].SubItems.Add("1200");
                lvUrunler.Items.Add("i5 7500", 1);
                lvUrunler.Items[1].SubItems.Add("750");
                lvUrunler.Items.Add("i3 7100", 2);
                lvUrunler.Items[2].SubItems.Add("500");
            }
            else if (lbMarkalar.SelectedItem.ToString() == "AMD")
            {
                lvUrunler.Items.Add("Ryzen 7");
                lvUrunler.Items[0].SubItems.Add("1200");
                lvUrunler.Items.Add("Ryzen 5");
                lvUrunler.Items[1].SubItems.Add("900");
                lvUrunler.Items.Add("Ryzen 3");
                lvUrunler.Items[2].SubItems.Add("800");
            }
            else if (lbMarkalar.SelectedItem.ToString() == "DDR4")
            {
                lvUrunler.Items.Add("Corsair 16 GB Dual kit");
                lvUrunler.Items[0].SubItems.Add("350");
                lvUrunler.Items.Add("Corsair 8GB");
                lvUrunler.Items[1].SubItems.Add("250");
                lvUrunler.Items.Add("Team 8GB");
                lvUrunler.Items[2].SubItems.Add("200");
            }
            else if (lbMarkalar.SelectedItem.ToString() == "DDR3")
            {
                lvUrunler.Items.Add("Kingston DDR3 8GB");
                lvUrunler.Items.Add("Kingston DDR3 16GB");
                lvUrunler.Items.Add("Kingston DDR3 2GB");
            }

            else if (lbMarkalar.SelectedItem.ToString() == "Nvidia")
            {
                lvUrunler.Items.Add("Nvidia GTX 1080");
                lvUrunler.Items[0].SubItems.Add("1800");
                lvUrunler.Items.Add("Nvidia GTX 1070");
                lvUrunler.Items[1].SubItems.Add("1250");
                lvUrunler.Items.Add("Nvidia GTX 1060");
                lvUrunler.Items[2].SubItems.Add("1000");
            }

            else if (lbMarkalar.SelectedItem.ToString() == "AMD")
            {
                lvUrunler.Items.Add("AMD RX 580");
                lvUrunler.Items.Add("AMD RX 560");
                lvUrunler.Items.Add("AMD RX 550");
            }
            else if (lbMarkalar.SelectedItem.ToString() == "Samsung")
            {
                lvUrunler.Items.Add("Samsung 256 GB SSD");
                lvUrunler.Items[0].SubItems.Add("300");
                lvUrunler.Items.Add("Samsung 1TB NVME 960 SSD");
                lvUrunler.Items[1].SubItems.Add("2250");
                lvUrunler.Items.Add("Samsung 512GB NVME 950 SSD");
                lvUrunler.Items[2].SubItems.Add("1250");
            }

        }

        int sayac = 0;
        int SepetToplam = 0;
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (lvUrunler.SelectedItems.Count!=0)
            {
                lvSepet.Items.Add(lvUrunler.SelectedItems[0].Text);
                lvSepet.Items[sayac].SubItems.Add(lvUrunler.SelectedItems[0].SubItems[1].Text);
                sayac++;
                for (int i = 0; i < lvSepet.Items.Count; i++)
                {
                    SepetToplam += Convert.ToInt32(lvSepet.Items[i].SubItems[1].Text);
                }

                if (SepetToplam != 0)
                {
                    txtSepetToplam.Text = SepetToplam.ToString();
                }
                SepetToplam = 0;
            }
            else
            {
                MessageBox.Show("Lütfen Bir Ürün Seçiniz!!!");
            }
        }

        private void detayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvUrunler.View = View.Details;
        }

        private void resimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvUrunler.View = View.LargeIcon;
        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvUrunler.View = View.List;
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvUrunler.View = View.Tile;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            String fatura = "Satın Aldıklarınız \n";
            for (int i = 0; i < lvSepet.Items.Count; i++)
            {
                fatura += lvSepet.Items[i].Text+ " - "+ lvSepet.Items[i].SubItems[1].Text + " TL" + "\n";
            }
            MessageBox.Show(fatura);
        }
    }
}
