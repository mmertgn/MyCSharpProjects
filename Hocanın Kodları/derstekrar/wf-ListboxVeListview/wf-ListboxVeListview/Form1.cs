using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_ListboxVeListview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lbSayilar.Items.Add("Merhaba");
            //lbSayilar.Items.RemoveAt(2);
            //if (lbSayilar.Items.Contains("Merhaba"))
            //{
            //    MessageBox.Show("Buldum!");
            //}
            //if (lbSayilar.Items.Contains("Selam"))
            //{
            //    MessageBox.Show("Buldum!");
            //}
            //else
            //{
            //    MessageBox.Show("Bulunamadı!");
            //}
            lbSayilar.Items.Clear();
            int Toplam=0,ortalama=0;
            for (int i = 1; i <= 10; i++)
            {
                lbSayilar.Items.Add(i);
                Toplam = Toplam + Convert.ToInt32(lbSayilar.Items[i-1]);
            }
            //MessageBox.Show("Toplam : " + Toplam);
            ortalama = Toplam / lbSayilar.Items.Count;
            //MessageBox.Show("Ortalama : " + ortalama);

        }

        private void lbSayilar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(lbSayilar.SelectedIndex.ToString());
            MessageBox.Show(lbSayilar.SelectedItem.ToString());
        }
    }
}
