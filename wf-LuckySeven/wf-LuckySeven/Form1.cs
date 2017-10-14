using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_LuckySeven
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Ekranda 3 tane sayı var, 3ünde de 7 ler gözüküyor, start adında buton var, start basıldığı anda 
        //sayılar rasgele dönmeye başlasın, başladığında startdaki yazı stop olsun ve sayı da dursun, 3 ü aynı ise 2si aynı
        //ise

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Random rnd = new Random();
        bool basildi = true;
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (basildi)
            {
                timer1.Enabled = true;
                btnStart.Text = "STOP";
                basildi = false;
            }
            else
            {
                timer1.Enabled = false;
                btnStart.Text = "START";
                basildi = true;
                if (label1.Text == label2.Text && label2.Text == label3.Text && label1.Text == label3.Text)
                {
                    MessageBox.Show("Tebrikler Kazandınız 3 TE 3!!!");
                }else if (label1.Text == label2.Text || label2.Text == label3.Text || label1.Text == label3.Text)
                {
                    MessageBox.Show("Tebrikler Kazandınız 2 Doğru!!!");
                }
                else
                {
                    MessageBox.Show("Kaybettin!!!");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(rnd.Next(1, 8));
            label2.Text = Convert.ToString(rnd.Next(1, 8));
            label3.Text = Convert.ToString(rnd.Next(1, 8));
        }
    }
}
