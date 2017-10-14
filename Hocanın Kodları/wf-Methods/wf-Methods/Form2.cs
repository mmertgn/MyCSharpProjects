using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_Methods
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Ortalama = " + OrtalamaBul(10, 20));
            float A = 10;
            float B = 20;
            MessageBox.Show("Ortalama = " + OrtalamaBul(A, B));
        }
        private float OrtalamaBul(float sayi1, float sayi2)
        {
            float Ort = (sayi1 + sayi2) / 2;
            return Ort;
            //return (sayi1 + sayi2) / 2;
        }
        private void btnOrtalamaBul_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ortalama = " + OrtalamaBul(Convert.ToSingle(txtSayi1.Text), Convert.ToSingle(txtSayi2.Text)));
        }
    }
}
