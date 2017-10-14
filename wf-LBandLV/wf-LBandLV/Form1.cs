using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_LBandLV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 100; i++)
            {
                lbSayilar.Items.Add(i);
            }
            int toplam = 0;
            for (int i = 0; i < lbSayilar.Items.Count; i++)
            {
                toplam = toplam + Convert.ToInt32(lbSayilar.Items[i]);
            }
            MessageBox.Show(toplam.ToString());
        }
    }
}
