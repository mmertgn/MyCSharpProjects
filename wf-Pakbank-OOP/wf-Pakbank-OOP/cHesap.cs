using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_Pakbank_OOP
{
    class cHesap
    {
        //Members,
        private int _hesapId;
        private string _hesapNo;
        private string _hesapAcilisTarihi;
        private string _adi;
        private string _soyadi;
        private string _tCKN;
        private double _ilkBakiye;
        private string _hesapTuru;

        //Properties
        #region Properties
        public int HesapId
        {
            get
            {
                return _hesapId;
            }

            set
            {
                _hesapId = value;
            }
        }

        public string HesapNo
        {
            get
            {
                return _hesapNo;
            }

            set
            {
                _hesapNo = value;
            }
        }

        public string HesapAcilisTarihi
        {
            get
            {
                return _hesapAcilisTarihi;
            }

            set
            {
                _hesapAcilisTarihi = value;
            }
        }

        public string Adi
        {
            get
            {
                return _adi;
            }

            set
            {
                _adi = value.Substring(0,1).ToUpper()+value.Substring(1).ToLower();
            }
        }

        public string Soyadi
        {
            get
            {
                return _soyadi;
            }

            set
            {
                _soyadi = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        public string TCKN
        {
            get
            {
                return _tCKN;
            }

            set
            {
                _tCKN = value;
            }
        }

        public double IlkBakiye
        {
            get
            {
                return _ilkBakiye;
            }

            set
            {
                _ilkBakiye = value;
            }
        }

        public string HesapTuru
        {
            get
            {
                return _hesapTuru;
            }

            set
            {
                _hesapTuru = value;
            }
        }
        #endregion

        //Methods
        #region Methods
        public int HesapIDOlustur()
        {

            StreamWriter DosyaOlustur = new StreamWriter("HesapKartlari.txt", true);
            DosyaOlustur.Close();
            int ID;
            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string okunan = DosyaOku.ReadLine(); //ilk satırı okur.
            if (okunan == null)
                ID = 1;
            else
            {
                string[] Degerler = new string[okunan.Split(';').Length];
                while (okunan != null)
                {
                    Degerler = okunan.Split(';');
                    okunan = DosyaOku.ReadLine();
                }
                ID = Convert.ToInt32(Degerler[0]) + 1;
            }
            DosyaOku.Close();
            return ID;
        }
        string YeniHesapNo;
        Random rnd = new Random();
        private bool HesapNoOlustur()
        {
            YeniHesapNo = "ACC" + rnd.Next(1000, 10000);
            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string okunan = DosyaOku.ReadLine();
            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');
                if (Degerler[1] == YeniHesapNo)
                {
                    DosyaOku.Close();
                    return true;
                }
                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
            return false;
        }
        public string HesapVarmi()
        {
            bool Varmi = false;
            do
            {
                Varmi = HesapNoOlustur();
            } while (Varmi);
            return YeniHesapNo;
        }

        public bool HesapAc(cHesap h)
        {
            StreamWriter DosyaEkle = new StreamWriter("HesapKartlari.txt", true);
            DosyaEkle.WriteLine(h._hesapId + ";" + h._hesapNo + ";" + h._hesapAcilisTarihi + ";" + h._adi + ";" + h._soyadi + ";" + h._tCKN + ";" + h._ilkBakiye + ";" + h._hesapTuru);
            DosyaEkle.Close();
           
            return true;
        }

        public cHesap HesapBilgileriGoster(string hesapNo)
        {
            cHesap h = new cHesap();
            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string okunan = DosyaOku.ReadLine();
            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');
                if (Degerler[1] == hesapNo)
                {
                    h.Adi = Degerler[3];
                    h.Soyadi = Degerler[4];
                    h.TCKN = Degerler[5];
                    h.HesapAcilisTarihi = Degerler[2];
                    h.HesapTuru = Degerler[7];
                    break; //hesabı bulduktan sonra aramaya devam etmesin.
                }
                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
            return h;
        }
        #endregion
    }
}
