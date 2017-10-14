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
            //MessageBox.Show(txtSayi1.Text + txtSayi2.Text); Text özelliğinde bilgiler string kabul edildiğinden + sembolü ile yanyana birleştirilir.
            int S1 = int.Parse(txtSayi1.Text);
            int S2 = int.Parse(txtSayi2.Text);
            int T = S1 + S2;
            //MessageBox.Show("Toplam = " + T);
            //MessageBox.Show((int.Parse(txtSayi1.Text) + int.Parse(txtSayi2.Text)).ToString());
            txtSonuc.Text = T.ToString();
        }
    }
}
