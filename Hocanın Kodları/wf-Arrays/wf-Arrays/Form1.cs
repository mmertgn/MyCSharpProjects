using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Takimlar = new string[5];
            Takimlar[0] = "Fenerbahçe"; 
            Takimlar[1] = "Beşiktaş";
            Takimlar[2] = "Galatasaray";
            Takimlar[3] = "Trabzonspor";
            Takimlar[4] = "Bursaspor";
            //Takimlar[5] = "Göztepe"; dizinin eleman sayısını aştığı için hata vericektir.

            MessageBox.Show(Takimlar[0]);  //Dizinin ilk elemanını görüntüler.

            //for (int i = 0; i < 5; i++)
            //{
            //    MessageBox.Show(Takimlar[i]);
            //}

            MessageBox.Show(Takimlar.Length.ToString()); //Dizinin eleman sayısını verir.

            //for (int i = 0; i < Takimlar.Length; i++)
            //{
            //    MessageBox.Show(Takimlar[i]);
            //}
            foreach (string takim in Takimlar)  //read-only, forward-only
            {
                MessageBox.Show(takim);
            }
        }
    }
}
