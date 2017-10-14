using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_Siralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] Sayilar = { 5, 8, 3, 11, 14, 2, 7, 6, 12, 4 };
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (int sayi in Sayilar)
            {
                lbIlkHali.Items.Add(sayi);
            }
            /*Array.Sort(Sayilar);*/ //Dizi elemanlarını küçükten büyüğe sıralar.
            /*Array.Reverse(Sayilar);*/ //Dizi elemanlarını tersten sıralar. (Büyükten küçüğe sıralanmış olurlar)
            int Temp = 0;
            for (int i = 0; i < Sayilar.Length - 1; i++)
            {
                for (int j = i + 1; j < Sayilar.Length; j++)
                {
                    if(Sayilar[j] < Sayilar[i])
                    {
                        Temp = Sayilar[i];
                        Sayilar[i] = Sayilar[j];
                        Sayilar[j] = Temp;
                    }
                }

            }


            foreach (int sayi in Sayilar)
            {
                lbSirali.Items.Add(sayi);
            }
        }
    }
}
