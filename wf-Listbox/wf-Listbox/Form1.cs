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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtGirilen.Text.Trim() != "")
            {
                if (lbListe.Items.Contains(txtGirilen.Text.ToLower()))
                {
                    MessageBox.Show("Bu isim zaten var!");
                }
                else
                {
                    lbListe.Items.Add(txtGirilen.Text);
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
            //lbListe.Items.Remove("sezgin"); //Belirtilen elemanı listeden siler ve diğerlerini başa doğru kaydırır.
            //lbListe.Items.RemoveAt(1); //Belirtilen sıradaki elemanı listeden siler ve diğerlerini başa doğru kaydırır.
            //lbListe.Items.Remove(lbListe.SelectedItem);
            //if (lbListe.SelectedItem != null)
            //{
            //    lbListe.Items.Remove(lbListe.SelectedItem);
            //}
            //else
            //{
            //    MessageBox.Show("Lütfen Bir Eleman Seçiniz!");
            //}

            if (lbListe.SelectedIndex != -1)
            {
                lbListe.Items.RemoveAt(lbListe.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Lütfen Bir Eleman Seçiniz!");
            }
        }

        private void btnArayaEkle_Click(object sender, EventArgs e)
        {
            //lbListe.Items.Insert(0, "Akif"); //Insert index verip eklemek için kullanılır.

            if (txtGirilen.Text.Trim() != "")
            {
                if (lbListe.SelectedItem != null)
                {
                    if (lbListe.Items.Contains(txtGirilen.Text.ToLower()))
                    {
                        MessageBox.Show("Bu isim zaten var!");
                    }
                    else
                    {
                        lbListe.Items.Insert(lbListe.SelectedIndex, txtGirilen.Text.ToLower());
                        txtGirilen.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Bir Eleman Seçiniz!");
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
                    //lbListe.SelectedItem = txtGirilen.Text.ToLower(); //selectedindex ile de yap
                    ////lbListe.SelectedIndex = ? ********
                    for (int i = 0; i < lbListe.Items.Count; i++)
                    {
                        if (lbListe.Items[i].ToString() == txtGirilen.Text.ToLower())
                        {
                            lbListe.SelectedIndex = i;
                        }
                    }
               
                }
                else
                {
                    MessageBox.Show("Bu isim listede yok!");
                }
            }
            else
            {
                MessageBox.Show("Öncelikle isim girmelisiniz!");
            }
        }
    }
}
