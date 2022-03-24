using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Çarşamba);
            Console.WriteLine((int)Gunler.Çarşamba);
            Console.WriteLine((int)Gunler.Pazar);

            int SıkcaklıkDegeri = 32;

            if (SıkcaklıkDegeri <= (int)HavaDurumu.Normal)
                Console.WriteLine("Dışarıya Çıkmak İçin Havanın Isınmasını Bekleyelim.");
            else if (SıkcaklıkDegeri >=(int)HavaDurumu.Sıcak)
                Console.WriteLine("Dışarıya Çıkmak için çok sıcak bir gün");
            else if (SıkcaklıkDegeri >= (int)HavaDurumu.Normal && SıkcaklıkDegeri<(int)HavaDurumu.ÇokSıcak)
                Console.WriteLine("Hadi Dışarıya Çıkarlım");

        }
    }

    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma = 24,
        Cumartesi,
        Pazar

    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sıcak = 25,
        ÇokSıcak = 30
    }
}
