using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_ToplamBulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            //MessageBox.Show((int.Parse(txtSayi1.Text) + int.Parse(txtSayi2.Text)).ToString());
            int sayi1 = int.Parse(txtSayi1.Text);
            int sayi2 = int.Parse(txtSayi2.Text);
            //MessageBox.Show("Toplam : " + (sayi1 + sayi2).ToString());

            txtSonuc.Text = (sayi1+sayi2).ToString();

        }
    }
}
