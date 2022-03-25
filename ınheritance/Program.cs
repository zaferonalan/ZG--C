using System;

namespace ınheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //                      Canlılar
            //                          |
            //         Bitkiler                 Hayvanlar
            //      |            |           |               |
            //  Tohumlu      Tohumsuz    Surungenler        Kuşlar   

            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("*******************");

            Kuslar martı = new Kuslar();
            martı.Ucmak();


        }
    }
}
