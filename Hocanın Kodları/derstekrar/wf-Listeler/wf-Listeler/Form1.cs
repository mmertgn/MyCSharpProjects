using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_Listeler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string değerToplam = "";
            //int[] diziad = new int[3];
            //diziad[0] = 5;
            //diziad[1] = 8;
            //MessageBox.Show(diziad[2].ToString());
            string[] jel = new string[5];
            jel[3] = "kivi";
            //for (int i = 0; i < jel.Length; i++)
            //{
            //    değerToplam +="\n"+ jel[i];
            //}
            //MessageBox.Show(değerToplam);
            jel.GetLength(3);




        }

        private void btnSifrele_Click(object sender, EventArgs e)
        {
            string[] Alfabe = new string[] { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "İ","I", "J","K","L","M","N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };
            string SMetin = txtMetin.Text;
            int alfabesira = 0;
            int[] alfabesırasi = new int[SMetin.Length];
            for (int i = 0; i < SMetin.Length; i++)
            {
                switch (SMetin[i])
                {
                    case 'A':
                        alfabesira = 0;

                        break;
                    default:
                        break;
                }
            }
            
        }
    }
}
