using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
           
           ArrayList Liste = new ArrayList();
        //    Liste.Add("Ayşe");
        //    Liste.Add(2);
        //    Liste.Add(true);
        //    Liste.Add('A');

        //    // İçerisinde verilere erişim
        //    Console.WriteLine(Liste[1]);

           foreach (var item in Liste)
           {
               Console.WriteLine(item);
           }

           //İçerisinde verilere erişim
           Console.WriteLine("***** Add Range *****");
        //    string[] renkler = {"Kırmızı","sarı","yesil"};
           List<int> sayilar = new List<int>(){1,8,3,7,9,92,5};
        //    Liste.AddRange(renkler);
           Liste.AddRange(sayilar);

           foreach (var item in Liste)
           {
               Console.WriteLine(item);
           }

           //Sort
           Console.WriteLine("***** Sort *****");
           Liste.Sort();

           
           foreach (var item in Liste)
           {
               Console.WriteLine(item);
           }

           //Binary Search
           Console.WriteLine("****** Binary Search *****");
           Console.WriteLine(Liste.BinarySearch(9));

            // Reverse
           Console.WriteLine("****** Reverse *****");
           Liste.Reverse();

           foreach (var item in Liste)
           {
               Console.WriteLine(item);
           }

           //Clear
           Console.WriteLine("****** Clear *****");
           Liste.Clear();

           foreach (var item in Liste)
           {
               Console.WriteLine(item);
           }

            Console.ReadKey();
        }
    }
}
