using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_ComboBox
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
    }
}
