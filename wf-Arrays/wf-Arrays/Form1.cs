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

        string[] Takimlar = new string[5];
        private void Form1_Load(object sender, EventArgs e)
        {
            Takimlar[0] = "Fenerbahçe"; //Dizinin ilk elemanı
            Takimlar[1] = "Galatasaray";
            Takimlar[2] = "Beşiktaş";
            Takimlar[3] = "Trabzonspor";
            Takimlar[4] = "Bursaspor";

            //MessageBox.Show("Dizinin Eleman Sayisi : " + Takimlar.Length.ToString());

            foreach (string takim in Takimlar) //read-only, forward-only
            {
                MessageBox.Show(takim);
            }

        }
        
    }
}
