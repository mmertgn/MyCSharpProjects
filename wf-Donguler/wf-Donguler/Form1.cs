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

        private void Form1_Load(object sender, EventArgs e)
        {
            //listBox1.Items.Add("Mobile");
        }
        int toplam, toplamtek, toplamcift;
        private void btnSayilar_Click(object sender, EventArgs e)
        {
            lbSayilar.Items.Clear();
            toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                lbSayilar.Items.Add(i);
                toplam = toplam + i;
                txtToplam.Text = Convert.ToString(toplam);
            }
        }

        private void btnTekSayilar_Click(object sender, EventArgs e)
        {
            lbTekSayilar.Items.Clear();
            toplamtek = 0;
            for (int i = 1; i <= 10; i = i +2)
            {
                lbTekSayilar.Items.Add(i);
                toplamtek = toplamtek + i;
                txtTekToplam.Text = Convert.ToString(toplamtek);
            }
        }

        private void btnCiftSayilar_Click(object sender, EventArgs e)
        {
            lbCiftSayilar.Items.Clear();
            toplamcift = 0;
            for (int i = 2; i <= 10; i = i + 2)
            {
                lbCiftSayilar.Items.Add(i);
                toplamcift = toplamcift + i;
                txtCiftToplam.Text = Convert.ToString(toplamcift);
            }
        }
    }
}
