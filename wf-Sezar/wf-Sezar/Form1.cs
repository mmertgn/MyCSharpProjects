using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_Sezar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSifrele_Click(object sender, EventArgs e)
        {
            string[] Alfabe = { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };
            string SMetin = txtMetin.Text.ToUpper();
            int AlfabeSira = 0;
            string SifreliMetin = "";
            string SifresizMetin = "";
            int sayac = 0, sayac2 = 0;
            while (SMetin.Length != sayac)
            {
                for (int i = 0; i < Alfabe.Length; i++)
                {
                    if (SMetin[sayac] == Convert.ToChar(Alfabe[i]))
                    {
                        AlfabeSira = i + 3;
                    }
                }

                SifreliMetin += Alfabe[AlfabeSira].ToString();
                sayac++;
            }

            while (SifreliMetin.Length != sayac2)
            {
                for (int i = 0; i < Alfabe.Length; i++)
                {
                    if (SifreliMetin[sayac2] == Convert.ToChar(Alfabe[i]))
                    {
                        AlfabeSira = i - 3;
                    }
                }

                SifresizMetin += Alfabe[AlfabeSira].ToString();
                sayac2++;
            }
            txtSifreli.Text = SifreliMetin;
            txtSifresiz.Text = SifresizMetin;
        }
    }
}
