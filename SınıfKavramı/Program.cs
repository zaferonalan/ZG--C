using System;

namespace SınıfKavramı
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

            Calısan Calısan1 = new Calısan();
            Calısan1.Ad = "Zafer Günay";
            Calısan1.SoyAd = "Önalan";
            Calısan1.No = 1547849;
            Calısan1.Departman = "Bilgi İşlem";
            Calısan1.CalısanBilgileri();

            Calısan Calısan2 = new Calısan();
            Calısan2.Ad = "Merve";
            Calısan2.SoyAd = "Önalan";
            Calısan2.No = 1547852;
            Calısan2.Departman = "Bilgi İşlem";
            Calısan2.CalısanBilgileri();

        }
    }

    public class Calısan
    {
        public string Ad;
        public string SoyAd;
        public int No;
        public string Departman;

        public void CalısanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı : {0} ", Ad);
            Console.WriteLine("Çalışanın Soyadı : {0}", SoyAd);
            Console.WriteLine("Çalışanın Numarası : {0}",No);
            Console.WriteLine("Çalışanın Birimi : {0}",Departman);
        }
    }
}
