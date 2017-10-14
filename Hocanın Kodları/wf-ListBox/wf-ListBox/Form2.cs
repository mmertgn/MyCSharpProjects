using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_ListBox
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSagaTek_Click(object sender, EventArgs e)
        {
            if(lbKullanicilar.SelectedIndex != -1)
            {
                lbSecilenler.Items.Add(lbKullanicilar.SelectedItem);
                lbKullanicilar.Items.Remove(lbKullanicilar.SelectedItem);
            }
        }
        private void btnSolaTek_Click(object sender, EventArgs e)
        {
            if (lbSecilenler.SelectedIndex != -1)
            {
                lbKullanicilar.Items.Add(lbSecilenler.SelectedItem);
                lbSecilenler.Items.Remove(lbSecilenler.SelectedItem);
            }
        }
        private void btnSagaCok_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbKullanicilar.SelectedItems.Count; i++)
            {
                lbSecilenler.Items.Add(lbKullanicilar.SelectedItems[i]);
                lbKullanicilar.Items.Remove(lbKullanicilar.SelectedItems[i]);
                i--; //Sildikten sonra yukarıya doğru kayma olduğundan sayacın artmasını önlüyoruz.
            }
        }
        private void btnSolaCok_Click(object sender, EventArgs e)
        {
            for (int i = lbSecilenler.SelectedItems.Count - 1; i >= 0; i--)
            {
                lbKullanicilar.Items.Add(lbSecilenler.SelectedItems[i]);
                lbSecilenler.Items.Remove(lbSecilenler.SelectedItems[i]);
            }
        }
    }
}
