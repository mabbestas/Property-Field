using System;

namespace PropertyField
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Burak";
            ogrenci.SoyIsim = "Beştaş";
            ogrenci.OgrenciNo = 56;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Isim = "Deniz";
            ogrenci1.SoyIsim = "Arda";
            ogrenci1.OgrenciNo = 256;
            ogrenci1.Sinif = 1;
            ogrenci1.OgrenciBilgileriniGetir();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();
        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyIsim;
        private int ogrenciNo;
        private int sinif;

        public string Isim
        {
            get => isim;
            set => isim = value;
        }
        public string SoyIsim
        {
            get => soyIsim;
            set => soyIsim = value;
        }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif
        {
            get => sinif;
            set
            {
               if (value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir!");
                    sinif = 1;
                }
               else
                {
                    sinif = value;
                }
            }
        }


        public Ogrenci(string isim, string soyIsim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            SoyIsim = soyIsim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci() { }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("***** Öğrenci Bilgileri *****");
            Console.WriteLine($"Öğrenci Adı:    {this.isim}");
            Console.WriteLine($"Öğrenci Soyadı: {this.soyIsim}");
            Console.WriteLine($"Öğrenci No:     {this.ogrenciNo}");
            Console.WriteLine($"Öğrenci Sınıfı: {this.sinif}");
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }
    }
}
