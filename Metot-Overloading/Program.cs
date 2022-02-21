using System;

namespace Metot_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Out parametreler
            string sayi ="999";

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başrılı");
                Console.WriteLine(outSayi);

            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4,5,out int toplamsonuc);
            Console.WriteLine(toplamsonuc);

            //Metot Aşırı Yükleme - Overloading

            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("ZaferGünay","Önalan");

            //Metot İmzası
            //metotAdı + parametre sayisi + parametre

        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int Toplam)
        {
            Toplam =a+b;
        }

         public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

         public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

         public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}
