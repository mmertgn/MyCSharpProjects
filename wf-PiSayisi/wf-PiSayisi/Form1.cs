using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_PiSayisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Dairenin Çevresi = 2*pi*r
        //Dairenin Alanı = Pi*r*r
        const float Pi = 3.14f; //constant (sabit) olarak tanımlanan ifadeler herhangi bir yerde değiştirilemez.
        float YariCap, Cevre, Alan;

        private void btnHesapla_Click(object sender, EventArgs e)
        {

            if (txtYariCap.Text.Trim() == "") //Trim gereksiz boşlukları yok sayar
            {
                MessageBox.Show("Yarıçap Değeri Giriniz!");
            }
            else
            {
                if (rbAlan.Checked == true)
                {
                    YariCap = Convert.ToSingle(txtYariCap.Text);
                    Alan = Pi * YariCap * YariCap;
                    MessageBox.Show("Dairenin Alanı : " + Alan.ToString());
                }
                else if (rbCevre.Checked == true)
                {
                    YariCap = Convert.ToSingle(txtYariCap.Text); //Convert ederken float ın özel adı single'dır.
                    Cevre = 2 * Pi * YariCap;
                    MessageBox.Show("Dairenin Çevresi : " + Cevre.ToString());
                }
            }
        }

        private void btnCevre_Click(object sender, EventArgs e)
        {
            if (txtYariCap.Text.Trim() == "") //Trim gereksiz boşlukları yok sayar
            {
                MessageBox.Show("Yarıçap Değeri Giriniz!");
            }
            else
            {
                YariCap = Convert.ToSingle(txtYariCap.Text); //Convert ederken float ın özel adı single'dır.
                Cevre = 2 * Pi * YariCap;
                MessageBox.Show("Dairenin Çevresi : " + Cevre.ToString());
            }
            txtYariCap.Focus();
        }

        private void btnAlan_Click(object sender, EventArgs e)
        {
            if (txtYariCap.Text.Trim() == "")
            {
                MessageBox.Show("Yarıçap Değeri Giriniz!");
            }
            else
            {
                YariCap = Convert.ToSingle(txtYariCap.Text);
                Alan = Pi * YariCap * YariCap;
                MessageBox.Show("Dairenin Alanı : " + Alan.ToString());
            }
            txtYariCap.Focus();
        }
    }
}
