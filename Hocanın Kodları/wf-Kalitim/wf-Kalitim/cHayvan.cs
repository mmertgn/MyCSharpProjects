using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_Kalitim
{
    class cHayvan : cCanli
    {
        private string _hareket;

        public string Hareket
        {
            get
            {
                return _hareket;
            }

            set
            {
                _hareket = value;
            }
        }
        public override void Beslen()
        {
            
        }
        public override void SuIc()
        {
            
        }
        public virtual string YeniDogan()
        {
            return "civciv";
        }
    }
}
