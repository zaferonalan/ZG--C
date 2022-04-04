using System;

namespace TelefonRehberi_Proje1
{
    class Program
    {
        static void Main(string[] args)
        {
            TelefonRehberiListe.RehberList.Add(new TelefonNumara ("Zafer Günay","Önalan", 6715));
            TelefonRehberiListe.RehberList.Add(new TelefonNumara("Merve","Önalan",6716));
            TelefonRehberiListe.RehberList.Add(new TelefonNumara("Meryem","Önalan",6717));
            TelefonRehberiListe.RehberList.Add(new TelefonNumara("Onay","Önalan",6718));
            TelefonRehberiListe.RehberList.Add(new TelefonNumara("Zerrin","Önalan",6719));

            YenidenDene:
            TelefonRehberi.Menu();
            int Sayi = int.Parse(Console.ReadLine());
            
            while (TelefonRehberi.SayiControl(Sayi))
            {
                if (Sayi == 1)
                {
                    TelefonRehberi.YeniKayit();
                    break;
                }
                else if(Sayi == 2)
                {
                    TelefonRehberi.NumaraSil();
                    break;
                }
                else if (Sayi == 3)
                {
                    TelefonRehberi.Guncelle();
                    break;
                }
                else if (Sayi == 4)
                {
                    TelefonRehberi.RehberiListeleme();
                }
                else if (Sayi == 5)
                {
                    TelefonRehberi.Arama();
                    break;
                }
                else
                {
                    Console.WriteLine("1 - 5 Sayi Aralığı dışında bir sayı girildi. Çıkılıyor...");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    goto YenidenDene;
                }
            }

            Console.WriteLine("Program Sona Erdi.");
            Console.ReadKey();

        }
    }
}
