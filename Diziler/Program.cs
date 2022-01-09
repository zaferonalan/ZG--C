using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dizi tanımlama

            string[] renkler = new string[5];

            string[] hayvanlar = {"Kedi","köpek","kuş","maymun"};

            int[] dizi;
            dizi = new int[5];

            // Dizilere Değer Atama Ve Erişim

            renkler[0]="Mavi";

            dizi[3] = 10;
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);


            //Döngülerle dizi kullanımı
            //klavyeden girilen n tane sayının ortalamasını hesaplayan prog.

            Console.Write("Lütfen dizinin eleman sayisini giriniz: ");
            int diziUzunlugu=int.Parse(Console.ReadLine());
            int[] sayıDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz",i+1);
                sayıDizisi[i] = int.Parse(Console.ReadLine());
            }

                 
            int toplam = 0;
            foreach (var sayi in sayıDizisi)
            {
                toplam += sayi;
            }

            Console.WriteLine("Ortalama :" + toplam/diziUzunlugu);

            Console.ReadKey();

            #endregion


        }
    }
}
