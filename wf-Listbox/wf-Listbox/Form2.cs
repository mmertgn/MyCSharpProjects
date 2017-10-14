using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_Listbox
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSagaTek_Click(object sender, EventArgs e)
        {
            if (lbKullanicilar.SelectedItem != null)
            {
                lbSecilenler.Items.Add(lbKullanicilar.SelectedItem);
                lbKullanicilar.Items.Remove(lbKullanicilar.SelectedItem);
            }
            else
            {
                MessageBox.Show("Lütfen Bir Eleman Seçiniz!");
            }
        }

        private void btnSolaTek_Click(object sender, EventArgs e)
        {
            if (lbSecilenler.SelectedItem != null)
            {
                lbKullanicilar.Items.Add(lbSecilenler.SelectedItem);
                lbSecilenler.Items.Remove(lbSecilenler.SelectedItem);
            }
            else
            {
                MessageBox.Show("Lütfen Bir Eleman Seçiniz!");
            }
        }

        private void btnSagaCok_Click(object sender, EventArgs e)
        {
            if (lbKullanicilar.SelectedItem != null)
            {
                
                for (int i = lbKullanicilar.SelectedItems.Count; i > 0; i--)
                {
                    lbSecilenler.Items.Add(lbKullanicilar.SelectedItem);
                    lbKullanicilar.Items.Remove(lbKullanicilar.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Eleman Seçiniz!");
            }
            
        }
         
        private void btnSolaCok_Click(object sender, EventArgs e)
        {
            if (lbSecilenler.SelectedItem != null)
            {

                for (int i = lbSecilenler.SelectedItems.Count; i > 0; i--)
                {
                    lbKullanicilar.Items.Add(lbSecilenler.SelectedItem);
                    lbSecilenler.Items.Remove(lbSecilenler.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Eleman Seçiniz!");
            }
        }
    }
}

