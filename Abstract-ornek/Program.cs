using System;

namespace Abstract_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
           
           Focus focus = new Focus();
           Console.WriteLine(focus.HangiMarkanınAracı());
           Console.WriteLine(focus.OtomobilKacTekerlek());
           Console.WriteLine(focus.StandartRengiNe());

           Console.WriteLine("******************");

           Civic civic = new Civic();
           Console.WriteLine(civic.HangiMarkanınAracı());
           Console.WriteLine(civic.OtomobilKacTekerlek());
           Console.WriteLine(civic.StandartRengiNe());

           Console.WriteLine("******************");

           Corolla corolla = new Corolla();
           Console.WriteLine(corolla.HangiMarkanınAracı());
           Console.WriteLine(corolla.OtomobilKacTekerlek());
           Console.WriteLine(corolla.StandartRengiNe());


        }
    }
}
