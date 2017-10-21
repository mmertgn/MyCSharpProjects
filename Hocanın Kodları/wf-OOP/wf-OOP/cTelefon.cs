using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_OOP
{
    class cTelefon
    {
        #region Members
        private string _marka;
        private string _model;
        private string _islemci;
        private string _hafiza;
        private string _ekran;
        private string _kamera;
        private double _fiyat; 
        #endregion

        #region Properties
        public string Marka
        {
            get
            {
                return _marka;
            }

            set
            {
                _marka = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }

            set
            {
                _model = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        public string Islemci
        {
            get
            {
                return _islemci;
            }

            set
            {
                _islemci = value;
            }
        }

        public string Hafiza
        {
            get
            {
                return _hafiza;
            }

            set
            {
                _hafiza = value;
            }
        }

        public string Ekran
        {
            get
            {
                return _ekran;
            }

            set
            {
                _ekran = value;
            }
        }

        public string Kamera
        {
            get
            {
                return _kamera;
            }

            set
            {
                _kamera = value;
            }
        }

        public double Fiyat
        {
            get
            {
                return _fiyat;
            }

            set
            {
                _fiyat = value;
            }
        } 
        #endregion

        public string AramaYap(string TelNo)
        {
            return TelNo + " aranıyor...";
        }
        public string MesajGonder(string TelNo, string Mesaj)
        {
            return TelNo + " telefona " + Mesaj + " mesajı gönderiliyor...";
        }

        public cTelefon(string Markasi, string Modeli)  //Parametreli Yapıcı Metot (Constructor)
        {
            Marka = Markasi;
            Model = Modeli;
        }
        public cTelefon()
        {

        }

        //Garbage Collector (Gereksiz Nesne Toplayıcı) erişilemeyen, kullanılmayan nesneleri hafızadan atar. Bu işlemi yaparken mutlaka Yıkıcı Metota uğrar.

        ~cTelefon()     //Yıkıcı Metot (Destructor)
        {
            MessageBox.Show("Nesneler hafızadan atılıyor!");
        }
    }
}
