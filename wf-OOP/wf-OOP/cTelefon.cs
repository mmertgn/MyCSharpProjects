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
        //region ile kodları gruplama yapabiliriz.
        #region Members
        private string _marka; // _ ve küçük harfle başlama sebebimiz encapsulation yaparken derleyici otomatik _kaldırıp ilk harfi büyütüp yazar
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
                _marka = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower(); //İlk harfi büyük diğer harfleri küçüğe çevirdik. Substring 1 ile 1.harften sonraki tüm harfleri seçtik
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
                _model = value;
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
            return TelNo + " aranıyor....";
        }
        public string MesajGonder(string Telefon, string Mesaj)
        {
            return "Mesajınız Başarıyla İletildi!";
        }

        public cTelefon(string Markasi,string Modeli) //Parametreli Yapıcı Metot
        {
            Marka = Markasi;
            Model = Modeli;
        }


        public cTelefon() //Parametresiz Yapıcı Metot
        {

        }

        //Garbage Collector (Gereksiz Nesne Toplayıcı) erişilemeyen,kullanılmayan nesneleri hafızadan atar.Bu işlemi yaparken mutlaka yıkıcı metota uğrar.

        ~cTelefon() //Yıkıcı Metot (Destructor)
        {
            MessageBox.Show("Nesneler Hafızadan Atılıyor.");
        }
    }
}
