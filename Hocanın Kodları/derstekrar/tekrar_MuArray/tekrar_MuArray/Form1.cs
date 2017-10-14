using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tekrar_MuArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string[,] kayitlar = new string[3,2];
            kayitlar[0, 0] = "Erkan";
            kayitlar[1, 0] = "Hilal";
            kayitlar[2, 0] = "abc";
            kayitlar[2, 1] = "emin";
            kayitlar[1, 1] = "muhammed";
            kayitlar[0, 1] = "kübra";
            //foreach (string item in kayitlar)
            //{
            //    MessageBox.Show(item);
            //}
            //for (int i = 0; i < kayitlar.GetLength(0); i++)
            //{
            //    for (int j = 0; j < kayitlar.GetLength(1); j++)
            //    {
            //        MessageBox.Show(kayitlar[i, j]);
            //    }
            //}

            char[,] dizi = new char[20, 20];
            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int j = 0; j < dizi.GetLength(1); j++)
                {
                    if (i==0 || j == 0 || i == 19 || j == 19)
                    {
                        dizi[i, j] = '*';
                    }
                    else
                    {
                        dizi[i, j] = ' ';
                    }
                   
                }
            }

            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                string a = "";
                for (int j = 0; j < dizi.GetLength(1); j++)
                {
                  
                    a += Convert.ToString(dizi[i, j]);
                }
                listBox1.Items.Add(a);
            }
        }
    }
}



