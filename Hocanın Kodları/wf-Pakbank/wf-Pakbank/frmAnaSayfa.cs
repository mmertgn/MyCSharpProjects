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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void mitmCikis_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit(); //Tüm uygulamayı sonlandırır.
        }
        private void mitmYeniHesap_Click(object sender, EventArgs e)
        {
            frmHesapAcilisi frm = new frmHesapAcilisi();
            //frm.Show();
            frm.ShowDialog(); //Aktif pencere kapatılmadan başka işlem yapılamaz.
        }
        private void mitmHesapDokumu_Click(object sender, EventArgs e)
        {
            frmHesapDokumu frm = new frmHesapDokumu();
            frm.ShowDialog();
        }
    }
}
