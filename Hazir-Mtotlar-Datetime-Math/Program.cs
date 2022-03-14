using System;

namespace Hazir_Mtotlar_Datetime_Math
{
    class Program
    {
        static void Main(string[] args)
        {
           
           Console.WriteLine(DateTime.Now); // günün tarihi
           Console.WriteLine(DateTime.Now.Date);
           Console.WriteLine(DateTime.Now.Day);
           Console.WriteLine(DateTime.Now.Month);
           Console.WriteLine(DateTime.Now.Year);
           Console.WriteLine(DateTime.Now.Hour);
           Console.WriteLine(DateTime.Now.Minute);
           Console.WriteLine(DateTime.Now.Second);

           Console.WriteLine(DateTime.Now.DayOfWeek);
           Console.WriteLine(DateTime.Now.DayOfYear);

           Console.WriteLine(DateTime.Now.ToLongDateString());
           Console.WriteLine(DateTime.Now.ToShortDateString());
           Console.WriteLine(DateTime.Now.ToLongTimeString());
           Console.WriteLine(DateTime.Now.ToShortTimeString());

           Console.WriteLine(DateTime.Now.AddDays(2));
           Console.WriteLine(DateTime.Now.AddHours(3));
           Console.WriteLine(DateTime.Now.AddSeconds(30));
           Console.WriteLine(DateTime.Now.AddMonths(5));
           Console.WriteLine(DateTime.Now.AddYears(10));
           Console.WriteLine(DateTime.Now.AddMilliseconds(50));

           //Datetime Format

           Console.WriteLine(DateTime.Now.ToString("dd")); //14
           Console.WriteLine(DateTime.Now.ToString("ddd")); //Mon
           Console.WriteLine(DateTime.Now.ToString("dddd")); //Monday

           Console.WriteLine(DateTime.Now.ToString("MM")); //03
           Console.WriteLine(DateTime.Now.ToString("MMM")); //mar
           Console.WriteLine(DateTime.Now.ToString("MMMM")); //march

           Console.WriteLine(DateTime.Now.ToString("yy")); //22
           Console.WriteLine(DateTime.Now.ToString("yyy")); //2022

            System.Console.WriteLine("******* Math Kütüphanesi******");
           //Math Kütüphanesi
           Console.WriteLine(Math.Abs(-25)); //25 mutlak
           Console.WriteLine(Math.Sin(10)); 
           Console.WriteLine(Math.Cos(10));
           Console.WriteLine(Math.Tan(10));

           Console.WriteLine(Math.Ceiling(22.3)); //23
           Console.WriteLine(Math.Round(22.3)); //22
           Console.WriteLine(Math.Round(22.7)); //23
           Console.WriteLine(Math.Floor(22.7)); //22

           Console.WriteLine(Math.Max(2,6));
           Console.WriteLine(Math.Min(2,6));

           Console.WriteLine(Math.Pow(3,4)); // 3^4 Ü VERİR. 81
           Console.WriteLine(Math.Sqrt(9)); // Karakök alır. 3
           Console.WriteLine(Math.Log(9)); // 9 un e tabanındaki logoritmasını alır.
           Console.WriteLine(Math.Exp(3)); // e üzeri 3 ü verir.
           Console.WriteLine(Math.Log10(10)); // 10 sayısının logaritma 10 tabanındaki karşılıgını verir.
           


           



        }
    }
}
