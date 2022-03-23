using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            //system.collection.generic;
            Dictionary<int,string> kullanıcılar =new Dictionary<int, string>();
            kullanıcılar.Add(10,"Zafer Günay Önalan");
            kullanıcılar.Add(12,"Merve Önalan");
            kullanıcılar.Add(18,"Zerrrin Önalan");
            kullanıcılar.Add(20,"Onay Önalan");
            kullanıcılar.Add(26,"Meryem Önalan");

            //Dizinin eleman sayısı
            Console.WriteLine("*****Elemanlara Erişim ******");
            Console.WriteLine(kullanıcılar[12]);
            foreach(var item in kullanıcılar)
                Console.WriteLine(item);
            
            //Count;
            Console.WriteLine("*****Count ******");
            Console.WriteLine(kullanıcılar.Count);

            //Contains
            Console.WriteLine("*****Contains ******");
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("Zafer Günay Önalan"));

            //Remove
            Console.WriteLine("***** Remove ******");
            kullanıcılar.Remove(12);
            foreach(var item in kullanıcılar)
                Console.WriteLine(item);
            
            //Keys
            Console.WriteLine("*****Keys ******");
            foreach (var item in kullanıcılar.Keys)
                Console.WriteLine(item);
            //Values
            Console.WriteLine("*****Values ******");
            foreach(var item in kullanıcılar.Values)
                Console.WriteLine(item);


        }
    }
}
