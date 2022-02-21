using System;

namespace Diziler_Array_Metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort

            int[] sayidizisi ={23,4,12,86,72,3,11,17};

        Console.WriteLine("****** Sırasız Liste ******");
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }

        System.Console.WriteLine("****** Sıralı Liste *******");
            Array.Sort(sayidizisi);

            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }

         Console.WriteLine("****** Array Clear ******");
             Array.Clear(sayidizisi,3,2);

             foreach(var sayi in sayidizisi)
                Console.WriteLine(sayi);

        Console.WriteLine("****** Array Reverse ******");
            Array.Reverse(sayidizisi);

                foreach(var sayi in sayidizisi)
                Console.WriteLine(sayi);

            
        Console.WriteLine("****** Array IndexOf ******");
            
            Console.WriteLine(Array.IndexOf(sayidizisi,23));

        Console.WriteLine("****** Array Resize ******");

        Array.Resize<int>(ref sayidizisi,9);
        sayidizisi[8] = 99;
        foreach (var sayi in sayidizisi)    
        Console.WriteLine(sayi);


        

        Console.ReadKey();


        }
    }
}
