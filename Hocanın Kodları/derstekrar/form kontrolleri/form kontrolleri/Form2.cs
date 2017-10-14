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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(txtSayi1.Text);
            sayi2 = Convert.ToInt32(txtSayi2.Text);
            if (rbTopla.Checked == true)
            {
                sonuc = sayi1 + sayi2;
            }
            else
            {
                sonuc = sayi1 - sayi2;
            }
            lblSonuc.Text = sonuc.ToString();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

