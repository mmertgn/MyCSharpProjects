using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_Kalitim
{
    sealed class cInsan : cHayvan
    {
        private string dusunur;

        public string Dusunur
        {
            get
            {
                return dusunur;
            }

            set
            {
                dusunur = value;
            }
        }
        public override string YeniDogan()
        {
            return "bebek";    //Aynı metot türetilen class'da farklı sonuç üretiyor (Polymorphism-Çok Biçimlilik)
        }
    }
}
