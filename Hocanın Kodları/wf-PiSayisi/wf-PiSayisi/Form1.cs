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
        const float Pi = 3.14f;
        float r, Cevre, Alan;
        private void Form1_Load(object sender, EventArgs e)
        {
            //Dairenin Çevresi = 2 x Pi x r
            //Dairenin Alanı   = Pi x r x r
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //Pi = 3.14756686678f; //(constant) sabit olarak tanımlanan ifadeler uygulama içinde değiştirilemez. 
            if (txtYaricap.Text.Trim() == "")
            {
                MessageBox.Show("Öncelikle yarıçap girmelisiniz!");
            }
            else
            {
                r = Convert.ToSingle(txtYaricap.Text);
                if (rbCevre.Checked == true)
                {
                    //Çevre hesabı yapılacak.
                    Cevre = 2 * Pi * r;
                    MessageBox.Show("Dairenin Çevresi = " + Cevre);
                }
                else
                {
                    //Alan hesabı yapılacak.
                    Alan = Pi * r * r;
                    MessageBox.Show("Dairenin Alanı = " + Alan);
                }
            }
            txtYaricap.Focus();
        }

        private void btnCevre_Click(object sender, EventArgs e)
        {
            if(txtYaricap.Text.Trim() == "")
            {
                MessageBox.Show("Öncelikle yarıçap girmelisiniz!");
            }
            else
            {
                r = Convert.ToSingle(txtYaricap.Text);
                Cevre = 2 * Pi * r;
                MessageBox.Show("Dairenin Çevresi = " + Cevre);
            }
            txtYaricap.Focus();
        }
        private void btnAlan_Click(object sender, EventArgs e)
        {
            if (txtYaricap.Text.Trim() == "")
            {
                MessageBox.Show("Öncelikle yarıçap girmelisiniz!");
            }
            else
            {
                r = Convert.ToSingle(txtYaricap.Text);
                Alan = Pi * r * r;
                MessageBox.Show("Dairenin Alanı = " + Alan);
            }
            txtYaricap.Focus();
        }
    }
}
