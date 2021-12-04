using System;

namespace console_programlama
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Write("İsmininizi Giriniz : ");
            string name = Console.ReadLine();
            Console.Write("Soyisimizi Giriniz : ");
            string surname = Console.ReadLine();

            Console.WriteLine("Hoşgeldiniz " + name + " " + surname);
            Console.ReadKey();


        }
    }
}
