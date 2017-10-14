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
            lbModeller.Items.Clear();
            if(cbMarkalar.SelectedItem.ToString() == "Apple")
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
    }
}
