using System;
using System.Collections;

namespace Soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            // Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            System.Console.Write("Kaç Adet Kelime Girişi Yapmak İstiyorsunuz : ");
            int AdetSayi;
            bool Kontrol = int.TryParse(Console.ReadLine(),out AdetSayi);
            
           
            if (AdetSayi > 0)
            {
                string [] Dizi = new string[AdetSayi];
                
                for (int i = 0; i < AdetSayi; i++)
                {
                    System.Console.Write("Lütfen {0}. Kelimenizi Giriniz : ",i+1);
                    Dizi[i] = Console.ReadLine();
                    
                }

                Array.Reverse(Dizi);
                System.Console.WriteLine("Kelimeler Tersten Yazılıyor...");
                System.Threading.Thread.Sleep(2000);

                foreach (var item in Dizi)
                {
                    System.Console.WriteLine(item);
                }

            }
            else
            {
                System.Console.WriteLine("Negatif Sayi Girişi Yaptınız.");
            }
         
        }
    }
}
