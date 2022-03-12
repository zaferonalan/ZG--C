using System;
using System.Collections;

namespace Soru2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            
            ArrayList Dizi = new ArrayList();
            System.Console.Write("Kaç Adet Sayı Girmek İstiyorsunuz: ");
            int AdetSayisi;
            bool Kontrol1 = int.TryParse(Console.ReadLine(),out AdetSayisi);

            System.Console.Write("Bölen Sayiyi Giriniz : ");
            int BolenSayi;
            bool Kontrol2 = int.TryParse(Console.ReadLine(),out BolenSayi);

            do
            {
                for (int i = 0; i < AdetSayisi; i++)
                {
                    YenidenDene:
                    System.Console.Write("{0}. Sayiyi Giriniz : ",i+1);
                    int KayitSayisi = int.Parse(Console.ReadLine());

                    if (KayitSayisi  % BolenSayi == 0 || KayitSayisi == BolenSayi)
                    {
                        Dizi.Add(KayitSayisi);
                    }
                    else if(KayitSayisi < 0 )
                    {
                        System.Console.WriteLine("Negatif Sayi Girişi Yaptınız Tekrar Deneyiniz.");
                        goto YenidenDene;
                    }
                }

                if (AdetSayisi > 0 && BolenSayi > 0)
                {
                    System.Console.WriteLine("Girmiş Olduğunuz Sayıların {0} Sayısına Tam Bölünenler Ve {1} Sayısana Eşit Olanlar : ",BolenSayi,BolenSayi);
                    foreach (var item in Dizi)
                    {
                        System.Console.WriteLine(item);
                    } 
                }
                   
                
            } while (AdetSayisi < 0 && BolenSayi < 0);
            
            if (AdetSayisi < 0 || BolenSayi < 0)
            {
                System.Console.WriteLine("Adet Sayisini veya Bölen Sayı Negatif Olamaz.");
            }
            Console.ReadKey();

        }
    }
}
