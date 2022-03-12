using System;
using System.Collections;

namespace Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
             //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            // Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            System.Console.Write("Kaç Adet Sayı Girişi Yapıcaksınız : ");
            int DiziUzunlugu;
            bool Kontrol = int.TryParse(Console.ReadLine(),out DiziUzunlugu);
            ArrayList Dizi = new ArrayList();
            do
            { 
                
                for (int i = 0; i < DiziUzunlugu; i++)
                {
                    YenidenDene:
                    System.Console.Write("{0}. Sayıyı Giriniz : ",i+1);
                    int GirilenDeger = int.Parse(Console.ReadLine());
                    if (GirilenDeger < 0)
                    {
                        System.Console.WriteLine("Negatif Değer Girdiniz Tektar Deneyiniz.");
                        goto YenidenDene;
                    }
                    else
                    {
                       if (GirilenDeger % 2 == 0)
                       {
                            Dizi.Add(GirilenDeger); 
                       }
                       
                    }
                    
                }

                if (DiziUzunlugu > 0)
                {
                    System.Console.Write("Girmiş Olduğunuz Çift Sayilar : ");
                    foreach (var item in Dizi)
                    {
                        System.Console.WriteLine(item);
                    }
                    
                }
               
            } while (DiziUzunlugu < 0 && Kontrol == false);

            System.Console.WriteLine("Adet Sayısını Negatif Girdiniz.");
            Console.ReadKey();

        }
    }
}
