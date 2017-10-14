using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_Pakbank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mitmHesapDokumu_Click(object sender, EventArgs e)
        {
            frmHesapDokumu frm = new frmHesapDokumu();
            frm.Show();
        }

        private void mitmyeniHesapOlusturma_Click(object sender, EventArgs e)
        {
            frmHesapAc frm = new frmHesapAc();
            frm.Show();
        }

        private void mitmCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            frmHesapAc frm = new frmHesapAc();
            frm.Show();
        }

        private void btnHesapDokumu_Click(object sender, EventArgs e)
        {
            frmHesapDokumu frm = new frmHesapDokumu();
            frm.Show();
        }
    }
}
