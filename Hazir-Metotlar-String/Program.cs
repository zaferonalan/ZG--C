﻿using System;

namespace Hazir_Metotlar_String
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2 = "dersimiz CSharp, Hoşgeldiniz!";
            //Length
            Console.WriteLine(degisken.Length); // Karakter sayisına ulaşılır.

            //ToUpper , ToLower
            System.Console.WriteLine(degisken.ToUpper());
            System.Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(string.Concat(degisken,"Merhaba")); 

            //Compare, CompareTo

            Console.WriteLine(degisken.CompareTo(degisken2)); // 0,1,-1
            Console.WriteLine(string.Compare(degisken,degisken2,true));
            Console.WriteLine(string.Compare(degisken,degisken2,false));

            //Constains

            Console.WriteLine(degisken.Contains(degisken2)); // degisken'in içerisinde degisken2 varmı bulursa true döncek
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Zafer"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba"));

            //PadLeft, PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50,'-') + degisken2);

            //Remove

            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //Replacce
            Console.WriteLine(degisken.Replace("CSharp,","c#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));

            
            


        }
    }
}
