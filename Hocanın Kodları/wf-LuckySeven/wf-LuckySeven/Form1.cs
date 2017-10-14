using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_LuckySeven
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl1.Text = rnd.Next(1, 8).ToString();
            lbl2.Text = rnd.Next(1, 8).ToString();
            lbl3.Text = rnd.Next(1, 8).ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start")
            {
                timer1.Enabled = true;
                btnStart.Text = "Stop";
            }
            else
            {
                timer1.Enabled = false;
                btnStart.Text = "Start";
                if(lbl1.Text == lbl2.Text && lbl2.Text == lbl3.Text)
                {
                    MessageBox.Show("Tebrikler! Hepsi aynı!", "WIN! WIN! WIN!");
                }
                else if(lbl1.Text == lbl2.Text || lbl1.Text == lbl3.Text || lbl2.Text == lbl3.Text)
                {
                    MessageBox.Show("İki sayı aynı", "Tebrikler, denemeye devam!");
                }
                else
                {
                    MessageBox.Show("Maalesef hepsi farklı", "Olsun yine de devam!");
                }
            }
        }
    }
}
