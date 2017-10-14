using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfFormKontrolleri
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int Sayi1, Sayi2, sonuc;
            Sayi1 = Convert.ToInt32(textBox1.Text);
            Sayi2 = Convert.ToInt32(textBox2.Text);

            if (rbTopla.Checked==true)
            {
                sonuc = Sayi1 + Sayi2;
            }
            else
            {
                sonuc = Sayi1 - Sayi2;
            }

            lblSonuc.Text = sonuc.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }
    }
}
