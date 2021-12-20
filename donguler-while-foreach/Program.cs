using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //While
            // 1 den başlayarak console dan girilen sayıya kadar sayı dahil
            // ortalama hesaplayıp console yazdıran prog.
            
            Console.Write("Bir Sayı Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac ++;
                 
            }

            Console.WriteLine("Ortalama : " + toplam / sayi);
            Console.ReadKey();


            // a' dan z' ye kadar tüm harfleri console a yazdırınız.

            char karakter = 'a';
            while (karakter <= 'z')
            {
                Console.Write(karakter);
                karakter++;

            }

            Console.WriteLine("***** Foreach *****");
            string[] arabalar ={"BMV" , "Ford" , "Toyota", "Nissan"};

            foreach (var araba in arabalar)
            {

                Console.WriteLine(araba);
                
            }

            Console.ReadKey();


        }
    }
}
