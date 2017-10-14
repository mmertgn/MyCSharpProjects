using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_BizimYaris4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd1 = new Random();
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            pb1.Enabled = true;
            pb2.Enabled = true;
            pb3.Enabled = true;
            pb4.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pb1.Left += rnd1.Next(1, 11);
            pb2.Left += rnd1.Next(1, 11);
            pb3.Left += rnd1.Next(1, 11);
            pb4.Left += rnd1.Next(1, 11);

            if (pb1.Right > this.Size.Width - 30)
            {
                timer1.Enabled = false;
                pb1.Enabled = false;
                pb2.Enabled = false;
                pb3.Enabled = false;
                pb4.Enabled = false;
                MessageBox.Show("1 Numaralı At Kazandı");
            }
            if (pb2.Right > this.Size.Width - 30)
            {
                timer1.Enabled = false;
                pb1.Enabled = false;
                pb2.Enabled = false;
                pb3.Enabled = false;
                pb4.Enabled = false;
                MessageBox.Show("2 Numaralı At Kazandı");

            }
            if (pb3.Right > this.Size.Width - 30)
            {
                timer1.Enabled = false;
                pb1.Enabled = false;
                pb2.Enabled = false;
                pb3.Enabled = false;
                pb4.Enabled = false;
                MessageBox.Show("3 Numaralı At Kazandı");

            }
            if (pb4.Right > this.Size.Width - 30)
            {
                timer1.Enabled = false;
                pb1.Enabled = false;
                pb2.Enabled = false;
                pb3.Enabled = false;
                pb4.Enabled = false;
                MessageBox.Show("4 Numaralı At Kazandı");

            }
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            pb1.Left = 30;
            pb2.Left = 30;
            pb3.Left = 30;
            pb4.Left = 30;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pb1.Enabled = false;
            pb2.Enabled = false;
            pb3.Enabled = false;
            pb4.Enabled = false;
        }
    }
}
