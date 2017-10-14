using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMarkalar.Text == "Apple")
            {
                lbModeller.Items.Clear();
                lbModeller.Items.Add("İphone X");
                lbModeller.Items.Add("İphone 8");
                lbModeller.Items.Add("İphone 8 Plus");
                lbModeller.Items.Add("İphone 7");
                lbModeller.Items.Add("İphone 7 Plus");
                lbModeller.Items.Add("İphone 6S");
            }
            else if (cbMarkalar.SelectedItem.ToString() == "Samsung")
            {
                lbModeller.Items.Clear();
                lbModeller.Items.Add("Galaxy S8");
                lbModeller.Items.Add("Galaxy S8 Plus");
                lbModeller.Items.Add("Note 8");
                lbModeller.Items.Add("Galaxy S7");
                lbModeller.Items.Add("Galaxy S7 EDGE");
            }
            else if (cbMarkalar.Text == "Nokia")
            {
                lbModeller.Items.Clear();
                lbModeller.Items.Add("Nokia 3");
                lbModeller.Items.Add("Nokia 5");
                lbModeller.Items.Add("Nokia 6");
            }
        }

        private void lbModeller_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvOzellikler.Items.Clear();
            if (lbModeller.SelectedItem.ToString() == "Galaxy S7")
            {
                lvOzellikler.Items.Add("1.5 GHZ");
                lvOzellikler.Items[0].SubItems.Add("3 GB");
                lvOzellikler.Items[0].SubItems.Add("5.1\"");
                lvOzellikler.Items[0].SubItems.Add("16 MP");
                lvOzellikler.Items[0].SubItems.Add("2250 TL");
            }
            else if (lbModeller.SelectedItem.ToString() == "Galaxy S8")
            {
                lvOzellikler.Items.Add("1.4 GHZ");
                lvOzellikler.Items[0].SubItems.Add("5 GB");
                lvOzellikler.Items[0].SubItems.Add("5.1\"");
                lvOzellikler.Items[0].SubItems.Add("16 MP");
                lvOzellikler.Items[0].SubItems.Add("1111 TL");
            }
            else if (lbModeller.SelectedItem.ToString() == "Galaxy S8 Plus")
            {
                lvOzellikler.Items.Add("2.4 GHZ");
                lvOzellikler.Items[0].SubItems.Add("6 GB");
                lvOzellikler.Items[0].SubItems.Add("5.1\"");
                lvOzellikler.Items[0].SubItems.Add("16 MP");
                lvOzellikler.Items[0].SubItems.Add("2500 TL");
            }
            else if (lbModeller.SelectedItem.ToString() == "Galaxy S7 EDGE")
            {
                lvOzellikler.Items.Add("1.8 GHZ");
                lvOzellikler.Items[0].SubItems.Add("4 GB");
                lvOzellikler.Items[0].SubItems.Add("5.1\"");
                lvOzellikler.Items[0].SubItems.Add("16 MP");
                lvOzellikler.Items[0].SubItems.Add("2000 TL");
            }
        }
    }
}
