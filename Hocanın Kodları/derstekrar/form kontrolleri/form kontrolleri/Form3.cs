using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_kontrolleri
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            //Textbox değerlerini temizliyoruz
            txtAdSoyad.Text = "";
            txtTelefon.Text = "";
            txtAdres.Text = "";

            //combobox değerlerini temizliyoruz
            cbPizzaBoy.Text = "";

            //numericupdown değerlerini temizliyoruz
            numPizza.Value = 0;

            //checkbox değerlerini temizliyoruz
            chbMantar.Checked = false;
            chbPeynir.Checked = false;
            chbSebze.Checked = false;

        }

        private void btnSiparisiAl_Click(object sender, EventArgs e)
        {
            //ucret ve ekstra adında değişkenler tanımlıyoruz
            decimal ucret = 0;
            string ekstra = "";

            //Eğer checkbox'lar seçili ise ekstra değişkenine aktarılıyor.
            if (chbMantar.Checked == true)
            {
                ekstra += " - " + "Mantar";
            }
            if (chbPeynir.Checked == true)
            {
                ekstra += " - " + "Peynir";
            }
            if (chbSebze.Checked == true)
            {
                ekstra += " - " + "Sebze";
            }


            //Seçili olan değeri ucret değişkenine adet bilgisi ile çarparak ekliyoruz.
            if (cbPizzaBoy.Text == "Küçük")
            {
                ucret = numPizza.Value * 10;
            }
            else if (cbPizzaBoy.Text == "Orta")
            {
                ucret = numPizza.Value * 15;
            }
            else if (cbPizzaBoy.Text == "Büyük")
            {
                ucret = numPizza.Value * 20;
            }

            //Listbox'a değerleri yazdırıyoruz.
            lbAdSoyad.Items.Add(txtAdSoyad.Text);
            lbAdres.Items.Add(txtAdres.Text);
            lbPizza.Items.Add(numPizza.Value + " adet " + cbPizzaBoy.Text);
            lbEkstra.Items.Add(ekstra);
            lbUcret.Items.Add(ucret + "TL");

        }


        private void btnSiparisleriTemizle_Click(object sender, EventArgs e)
        {
            //Listbox'ları temizliyoruz.
            lbAdSoyad.Items.Clear();
            lbAdres.Items.Clear();
            lbPizza.Items.Clear();
            lbEkstra.Items.Clear();
            lbUcret.Items.Clear();
        }

        private void Artır_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value != 100)    // If koymazsak 100den sonra hata verir.
            {
                progressBar1.Value += 20;
            }
            else if (progressBar1.Value == 100)
            {
                MessageBox.Show("Sipariş Hazır");
            }
        }
    }
}



