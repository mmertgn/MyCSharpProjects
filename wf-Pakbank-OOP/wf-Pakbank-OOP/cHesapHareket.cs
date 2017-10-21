using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_Pakbank_OOP
{
    class cHesapHareket
    {
        private int _hesapId;
        private string _hesapNo;
        private string _islemTarihi;
        private string _bakiye;
        private string _islemTuru;

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

        public string IslemTarihi
        {
            get
            {
                return _islemTarihi;
            }

            set
            {
                _islemTarihi = value;
            }
        }

        public string Bakiye
        {
            get
            {
                return _bakiye;
            }

            set
            {
                _bakiye = value;
            }
        }

        public string IslemTuru
        {
            get
            {
                return _islemTuru;
            }

            set
            {
                _islemTuru = value;
            }
        }
        #endregion

        public bool HareketEkle(int ID, string HesapNumarasi, string IslemTarihi, double IslemTutari,string IslemTuru)
        {
            StreamWriter HareketEkle = new StreamWriter("HesapHareketleri.txt", true);
            HareketEkle.WriteLine(ID + ";" + HesapNumarasi + ";" + IslemTarihi + ";" + IslemTutari + ";" + IslemTuru);
            HareketEkle.Close();
            return true;
        }
        public bool HareketEkle(cHesapHareket hareket)
        {
            StreamWriter HareketEkle = new StreamWriter("HesapHareketleri.txt", true);
            HareketEkle.WriteLine(hareket._hesapId + ";" + hareket._hesapNo + ";" + hareket._islemTarihi + ";" + hareket._bakiye + ";" + hareket._islemTuru);
            HareketEkle.Close();
            return true;
        }

        public void HesapHareketleriGoster(string hesapNo,ListView lvHareketler)
        {
            StreamReader DosyaOku = new StreamReader("HesapHareketleri.txt");
            string okunan = DosyaOku.ReadLine();
            int i = 0;
            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');
                if (Degerler[1] == hesapNo)
                {
                    lvHareketler.Items.Add(Degerler[0]);
                    lvHareketler.Items[i].SubItems.Add(Degerler[1]);
                    lvHareketler.Items[i].SubItems.Add(Degerler[2]);
                    lvHareketler.Items[i].SubItems.Add(Degerler[3]);
                    lvHareketler.Items[i].SubItems.Add(Degerler[4]);
                    i++;
                }
                okunan = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
        }
    }
}
