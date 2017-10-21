using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_Pakbank_OOP
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void mitmHesapDokumu_Click(object sender, EventArgs e)
        {
            frmHesapDokumu frm = new frmHesapDokumu();
            FormAcikmi(frm);
            
            //frm.ShowDialog();
            //frm.MdiParent = this;
            //frm.Show();

        }

        private void FormAcikmi(Form AcilacakForm)
        {
            bool Acikmi = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (AcilacakForm.Name == this.MdiChildren[i].Name)
                {
                    this.MdiChildren[i].Focus();
                    Acikmi = true;
                }
            }
            if (Acikmi == false)
            {
                AcilacakForm.MdiParent = this;
                AcilacakForm.Show();
            }else
            {
                AcilacakForm.Dispose(); //Artık kullanılmyacak form nesnesini hafızadan atıyoruz.
                //Biz yapmasak Garbage Collector bu işlemi bir süre sonra yapar.
            }

        }
        //private void FormAcikmi(Form AcilacakForm)
        //{
        //    foreach (Form frm in this.MdiChildren)
        //    {
        //        if (frm.Name == AcilacakForm.Name)
        //        {
        //            frm.Focus();
        //            return;
        //        }
        //    }
        //    AcilacakForm.MdiParent = this;
        //    AcilacakForm.Show();

        //}

        private void mitmyeniHesapOlusturma_Click(object sender, EventArgs e)
        {
            frmHesapAc frm = new frmHesapAc();
            FormAcikmi(frm);
            
            //frm.ShowDialog();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void mitmCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
