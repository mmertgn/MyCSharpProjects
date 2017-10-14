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
            lbModeller.Items.Clear();
            if (cbMarkalar.SelectedItem.ToString() == "Apple")
            {
                lbModeller.Items.Add("IPhone 6");
                lbModeller.Items.Add("IPhone 7");
                lbModeller.Items.Add("IPhone 8");
            }
            else if (cbMarkalar.SelectedItem.ToString() == "Samsung")
            {
                lbModeller.Items.Add("Galaxy S7");
                lbModeller.Items.Add("Galaxy S7 Edge");
                lbModeller.Items.Add("Galaxy S8");
            }
            else if (cbMarkalar.SelectedItem.ToString() == "Nokia")
            {
                lbModeller.Items.Add("Lumia 1120");
                lbModeller.Items.Add("Lumia 1320");
                lbModeller.Items.Add("Lumia 1520");
            }
        }
        private void lbModeller_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvOzellikler.Items.Clear();
            if(lbModeller.SelectedItem.ToString() == "IPhone 6")
            {
                lvOzellikler.Items.Add("1,4 GHz");
                lvOzellikler.Items[0].SubItems.Add("1 GB");
                lvOzellikler.Items[0].SubItems.Add("4,7 inch");
                lvOzellikler.Items[0].SubItems.Add("8 MP");
                lvOzellikler.Items[0].SubItems.Add("2000");
            }
            else if (lbModeller.SelectedItem.ToString() == "IPhone 7")
            {
                lvOzellikler.Items.Add("1,6 GHz");
                lvOzellikler.Items[0].SubItems.Add("2 GB");
                lvOzellikler.Items[0].SubItems.Add("5,1 inch");
                lvOzellikler.Items[0].SubItems.Add("10 MP");
                lvOzellikler.Items[0].SubItems.Add("2600");
            }
            else if (lbModeller.SelectedItem.ToString() == "IPhone 8")
            {
                lvOzellikler.Items.Add("2,3 GHz");
                lvOzellikler.Items[0].SubItems.Add("4 GB");
                lvOzellikler.Items[0].SubItems.Add("4,7 inch");
                lvOzellikler.Items[0].SubItems.Add("12 MP");
                lvOzellikler.Items[0].SubItems.Add("4000");
            }
            else if (lbModeller.SelectedItem.ToString() == "Galaxy S7")
            {
                lvOzellikler.Items.Add("1,6 GHz");
                lvOzellikler.Items[0].SubItems.Add("2 GB");
                lvOzellikler.Items[0].SubItems.Add("5,1 inch");
                lvOzellikler.Items[0].SubItems.Add("12 MP");
                lvOzellikler.Items[0].SubItems.Add("2700");
            }
            else if (lbModeller.SelectedItem.ToString() == "Galaxy S7 Edge")
            {
                lvOzellikler.Items.Add("1,7 GHz");
                lvOzellikler.Items[0].SubItems.Add("3 GB");
                lvOzellikler.Items[0].SubItems.Add("5,5 inch");
                lvOzellikler.Items[0].SubItems.Add("12 MP");
                lvOzellikler.Items[0].SubItems.Add("2900");
            }
        }
    }
}
