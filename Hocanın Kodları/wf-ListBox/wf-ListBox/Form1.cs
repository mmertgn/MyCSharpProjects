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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbListe.Items.Add("ayşegül");
        }
        private void lbListe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtGirilen.Text.Trim() != "")
            {
                if (lbListe.Items.Contains(txtGirilen.Text.ToLower()))
                {
                    MessageBox.Show("Listede mevcut!");
                }
                else
                {
                    lbListe.Items.Add(txtGirilen.Text.ToLower());
                    txtGirilen.Clear();
                }
            }
            else
            {
                MessageBox.Show("Öncelikle isim girmelisiniz!");
            }
            txtGirilen.Focus();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            /*lbListe.Items.Remove("sezgin");*/ //Belirtilen elemanı listeden siler ve diğerleri başa doğru kaydırır.
            /*lbListe.Items.RemoveAt(1);*/ //Belirtilen sıradaki elemanı listeden siler ve diğerleri başa doğru kaydırır.
            //lbListe.Items.Remove(lbListe.SelectedItem);
            //if (lbListe.SelectedIndex == -1)
            //    MessageBox.Show("Öncelikle seçim yapmalısınız!");
            //else
            //    lbListe.Items.RemoveAt(lbListe.SelectedIndex);
            if (lbListe.SelectedItem == null)
                MessageBox.Show("Öncelikle seçim yapmalısınız!");
            else
                lbListe.Items.Remove(lbListe.SelectedItem);
        }
        private void btnArayaEkle_Click(object sender, EventArgs e)
        {
            //lbListe.Items.Insert(0, "Akif");
            if (txtGirilen.Text.Trim() != "")
            {
                if (lbListe.Items.Contains(txtGirilen.Text.ToLower()))
                {
                    MessageBox.Show("Listede mevcut!");
                }
                else
                {
                    if (lbListe.SelectedIndex == -1)
                        MessageBox.Show("Nereye ekleneceğini seçmelisiniz!");
                    else
                    {
                        lbListe.Items.Insert(lbListe.SelectedIndex, txtGirilen.Text.ToLower());
                        txtGirilen.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Öncelikle isim girmelisiniz!");
            }
            txtGirilen.Focus();
        }
        private void btnBul_Click(object sender, EventArgs e)
        {
            if (txtGirilen.Text.Trim() != "")
            {
                if (lbListe.Items.Contains(txtGirilen.Text.ToLower()))
                {
                    //lbListe.SelectedItem = txtGirilen.Text.ToLower();
                    for (int i = 0; i < lbListe.Items.Count; i++)
                    {
                        if(lbListe.Items[i].ToString() == txtGirilen.Text.ToLower())
                        {
                            lbListe.SelectedIndex = i;
                        }
                    }
                }
                else { MessageBox.Show("Aradığınız listede yok!"); }
            }
            else
            {
                MessageBox.Show("Öncelikle isim girmelisiniz!");
            }
            txtGirilen.Focus();
        }
    }
}
