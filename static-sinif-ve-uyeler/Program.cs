using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı : {0}",Calisan.Calisansayisi);
            Calisan calisan = new Calisan("Zafer Günay","Önalan","IT");
            Console.WriteLine("Çalışan Sayisi : {0}",Calisan.Calisansayisi);

            Console.WriteLine("Toplama İşlemi Sonucu : {0}", Islemler.Topla(100,200));
            Console.WriteLine("Çıkartma İşlemi Soncu : {0}", Islemler.Cıkart(400,50));
            
            Console.ReadKey();
        }
    }

    class Calisan
    {
        private static int calisansayisi;
        public static int Calisansayisi { get => calisansayisi;}
        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan(){
            calisansayisi = 0;
        }
        public Calisan(string ısim, string soyisim, string departman)
        {
            this.Isim = ısim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisansayisi ++;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1 , int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static long Cıkart(int sayi1 , int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
