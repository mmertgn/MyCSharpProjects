using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_kontrolleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAc_Click(object sender, EventArgs e)
        {

            txtBilgi.Text = "Merhaba, bugün sizlere Form Kontrollerinden bahsedeceğim.";
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
