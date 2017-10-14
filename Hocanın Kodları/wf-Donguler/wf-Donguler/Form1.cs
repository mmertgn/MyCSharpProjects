using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_Donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Toplam;
        private void Form1_Load(object sender, EventArgs e)
        {
            //listBox1.Items.Add("Mobile");
        }
        private void btnSayilar_Click(object sender, EventArgs e)
        {
            lbSayilar.Items.Clear();
            Toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                lbSayilar.Items.Add(i);
                Toplam += i;
            }
            txtToplam.Text = Toplam.ToString();
        }
        private void btnTekSayilar_Click(object sender, EventArgs e)
        {
            lbTekSayilar.Items.Clear();
            Toplam = 0;
            for (int i = 1; i <= 10; i+=2)
            {
                lbTekSayilar.Items.Add(i);
                Toplam += i;
            }
            txtTekToplam.Text = Toplam.ToString();
        }
        private void btnCiftSayilar_Click(object sender, EventArgs e)
        {
            lbCiftSayilar.Items.Clear();
            Toplam = 0;
            for (int i = 2; i <= 10; i += 2)
            {
                lbCiftSayilar.Items.Add(i);
                Toplam += i;
            }
            txtCiftToplam.Text = Toplam.ToString();
        }
    }
}
