using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_PakBank_OOP
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void mitmYeniHesap_Click(object sender, EventArgs e)
        {
            frmHesapAcilisi frm = new wf_PakBank_OOP.frmHesapAcilisi();
            frm.ShowDialog();
        }

        private void mitmCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
