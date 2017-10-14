using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_PztesiSunum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Trim() != "")
            {
                lbAdlar.Items.Insert(1, txtAd.Text);
            }
            if (lbAdlar.Items.Contains(txtAd.Text))
            {
                MessageBox.Show("Buldum");
            }
        }
    }
}
