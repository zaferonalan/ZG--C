using System;

namespace struct_kavramı
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Dikdörtgen dikdörtgen = new Dikdörtgen();
           // dikdörtgen.KisaKenar = 4;
           // dikdörtgen.UzunKenar = 6;
            Console.WriteLine("Class Alan Hesabı : {0}",dikdörtgen.ClassAlanHesap());

            Dikdörtgenstruct dikdörtgenstruct;
            dikdörtgenstruct.KisaKenarSturuct = 4;
            dikdörtgenstruct.UzunKenarSturuct = 6;
            Console.WriteLine("Struct Alan Hesabı : {0}",dikdörtgenstruct.StructAlanHesap());

            Console.ReadKey();

        }
    }

    class Dikdörtgen
    {
        public int KisaKenar;
        public int UzunKenar;
        public long ClassAlanHesap()
        {
            return this.KisaKenar * this.UzunKenar;
        } 
       // public Dikdörtgen()
        //{
          //  KisaKenar = 4;
          //  UzunKenar = 6;
        //}
    }
    struct Dikdörtgenstruct
    {
        public int KisaKenarSturuct;
        public int UzunKenarSturuct;

        public long StructAlanHesap()
        {
            return this.KisaKenarSturuct * this.UzunKenarSturuct;
        }
        public Dikdörtgenstruct()
        {
            KisaKenarSturuct = KisaKenarSturuct;
            UzunKenarSturuct = UzunKenarSturuct;
        }
    }
}
