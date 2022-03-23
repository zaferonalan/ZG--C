using System;
using System.Collections;
using System.Collections.Generic;
namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan prog.


            Console.Write("Bir Cümle Yazınız : ");
            string Cümle = Console.ReadLine();
            char[] SesliHarf ={'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü'};
            ArrayList BulunanDegerList = new ArrayList();

            foreach (var karakter in Cümle)
            {
                foreach (var harf in SesliHarf)
                {
                    if ( karakter == harf)
                    {
                       BulunanDegerList.Add(harf);
                    }
                }
            }

            System.Console.WriteLine("Bulunan Sesli Harfler : ");
            foreach (var item in BulunanDegerList)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}
