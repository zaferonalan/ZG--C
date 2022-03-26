using System;

namespace Interface_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
           
           Focus focus = new Focus();
           Console.WriteLine( focus.HangiMarkadanınAraci().ToString());
           Console.WriteLine( focus.KaçTekerlektenOlusur());
           Console.WriteLine( focus.StandartRengiNe().ToString());
           
           Console.WriteLine("******************");

           Civic civic = new Civic();
           Console.WriteLine( civic.HangiMarkadanınAraci().ToString());
           Console.WriteLine( civic.KaçTekerlektenOlusur());
           Console.WriteLine( civic.StandartRengiNe().ToString());

           Console.WriteLine("******************");
           
           Corolla corolla = new Corolla();
           Console.WriteLine( corolla.HangiMarkadanınAraci().ToString());
           Console.WriteLine( corolla.KaçTekerlektenOlusur());
           Console.WriteLine( corolla.StandartRengiNe().ToString());
        }
    }
}
