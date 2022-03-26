using System;

namespace polymorphism_ve_sealed_class
{
    class Program
    {
        static void Main(string[] args)
        {
            
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("*******************");

            Kuslar martı = new Kuslar();
            martı.Ucmak();
            
            

        }
    }
}
