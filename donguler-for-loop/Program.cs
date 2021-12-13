using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekranadan girilen sayıya kadar olan tek sayıları ekrana yazdır.
            
            Console.Write("Bir Sayı Giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= sayi; i++)
            {
                if(i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
                
            }

            // 1 ile 1000 arasındaki tek ve çift sayıların kendi içinde toplamlarını yazan prog
            int Tektoplam = 0;
            int Cifttoplam = 0;
            Console.Write("Bir Sayı Giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            for (int a = 0; a < sayi2; a++)
            {
                if (a % 2 == 0)
                {
                    Cifttoplam += a;

                }
                else
                Tektoplam += a;
            }

            Console.WriteLine("Tek Toplam : " + Tektoplam);
            Console.WriteLine("Çift Toplam : " + Cifttoplam);

            // break, continue

            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                    break;
                Console.WriteLine(i);
            }

             for (int i = 1; i < 10; i++)
            {
                if(i==4)
                    continue;
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
