using System;

namespace Kurucu_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            // class SinifAdi
            // {
            //     [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
            //     [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi])
            //     {
            //         Metot Komutları        
            //     }
            // }


            //Erişim Belirleyiciler
            // * Public
            // * Private
            // * Internal
            // * Protected

            Console.WriteLine("***** Calışan1 *****");
            Calısan Calısan1 = new Calısan("Zafer Günay","Önalan",1547849,"Bilgi İşlem");
            Calısan1.CalısanBilgileri();

            Console.WriteLine("***** Calışan2 *****");
            Calısan Calısan2 = new Calısan();
            Calısan2.Ad = "Merve";
            Calısan2.SoyAd = "Önalan";
            Calısan2.No = 1547852;
            Calısan2.Departman = "Bilgi İşlem";
            Calısan2.CalısanBilgileri();

            Console.WriteLine("***** Calışan3 *****");
            Calısan Calısan3 = new Calısan("Zerrin","Önalan",1547849,"Bilgi İşlem");
            Calısan3.CalısanBilgileri();

        }
    }

    public class Calısan
    {
        public string Ad;
        public string SoyAd;
        public int No;
        public string Departman;

        public Calısan(string ad , string soyad , int no , string departman)
        {
            this.Ad = ad;
            this.SoyAd = soyad;
            this.No = no;
            this.Departman = departman;
        }

         public Calısan(string ad , string soyad)
        {
            this.Ad = ad;
            this.SoyAd = soyad;
        }
        public Calısan(){}

        public void CalısanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı : {0} ", Ad);
            Console.WriteLine("Çalışanın Soyadı : {0}", SoyAd);
            Console.WriteLine("Çalışanın Numarası : {0}",No);
            Console.WriteLine("Çalışanın Birimi : {0}",Departman);
        }
            

        
    }
}
