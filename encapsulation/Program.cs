using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogrenci1 = new ogrenci();
            ogrenci1.Ad="Zafer Günay";
            ogrenci1.Soyad="Önalan";
            ogrenci1.No=6715;
            ogrenci1.Sinif = 3;
            ogrenci1.OgrenciBilgileriniGetir();

            ogrenci1.SinifArttir();
            ogrenci1.OgrenciBilgileriniGetir();

            ogrenci ogrenci2 = new ogrenci();
            ogrenci2.Ad = "Merve";
            ogrenci2.Soyad = "Önalan";
            ogrenci2.No = 8475;
            ogrenci2.Sinif = 1;
            ogrenci2.SinifDüsür();
            ogrenci2.OgrenciBilgileriniGetir();

            Console.ReadKey();


        }
    }

    class ogrenci
    {
        private string ad;
        private string soyad;
        private int no;
        private int sinif;

        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public int No { get => no; set => no = value; }
        public int Sinif 
        {
            get => sinif;
            set
            { 
                if (value < 1)
                {
                    Console.WriteLine("Sınıf En Az 1 Olabilir.");
                    sinif = 1;
                }
                else
                    sinif = value;
            } 
        }

        public ogrenci(string ad, string soyad, int no, int sinif)
        {
            Ad = ad;
            Soyad = soyad;
            No = no;
            Sinif = sinif;
        }
        public ogrenci(){}

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("****** Öğrenci Bilgileri ******");
            Console.WriteLine("Öğrencinin Adı       : {0}",this.Ad);
            Console.WriteLine("Öğrencinin Soyadı    : {0}",this.Soyad);
            Console.WriteLine("Öğrencinin Numarası  : {0}",this.No);
            Console.WriteLine("Öğrencinin Sınıfı    : {0}",this.Sinif);
        }

        public void SinifArttir()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDüsür()
        {
            this.Sinif = this.Sinif - 1;
        }
        
    }

}
