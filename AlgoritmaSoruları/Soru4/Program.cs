using System;

namespace Soru4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            System.Console.Write("Bir Cümle Giriniz :");
            string GirisCumle = Console.ReadLine();
            string [] KelimeDizisi = GirisCumle.Split();
            int HarfSayisi = 0;

            System.Console.WriteLine("Girmiş Olduğunuz Cümle {0} Kelimeden Oluşmaktadır. ",KelimeDizisi.Length);

           for (int i = 0; i < KelimeDizisi.Length; i++)
           {
                char [] HarfDizisi = KelimeDizisi[i].ToCharArray();
                HarfSayisi += HarfDizisi.Length;
           }
            
            System.Console.WriteLine("Girmiş Olduğunuz Cümle {0} Harften Oluşmaktadır. ",HarfSayisi);

            

        }
    }
}
