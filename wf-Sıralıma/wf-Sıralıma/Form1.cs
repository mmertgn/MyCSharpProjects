using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_Sıralıma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] Sayilar = { 5,8,3,11,14,2,7,6,12,4 };

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (int sayi in Sayilar)
            {
                lbIlkHali.Items.Add(sayi);
            }
            ////Array.Sort(Sayilar); //Dizi elemanlarını küçükten büyüğe sıralar.
            //Array.Reverse(Sayilar); //Dizi elemanlarını tersten sıralar. (Önce Sort sonra Reverse yaparsak büyükten küçüğe dizilmiş olur.)

            //foreach (int sayi in Sayilar)
            //{
            //    lbSiraliHali.Items.Add(sayi);
            //}

            for (int i = 0; i < Sayilar.Length-1; i++)
            {
                for (int j = 0; j < Sayilar.Length-1; j++)
                {
                    if (Sayilar[j + 1] < Sayilar[j])
                    {
                        int tmp = Sayilar[j];
                        Sayilar[j] = Sayilar[j + 1];
                        Sayilar[j + 1] = tmp;
                    }
                }
                
            }
            
            foreach (int sayi in Sayilar)
            {
                lbSiraliHali.Items.Add(sayi);
            }
            
        }
    }
}
