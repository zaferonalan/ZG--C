using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın.
            // (ArrayList sınıfını kullanara yazınız.)
                //
                // Negatif ve numeric olmayan girişleri engelleyin.
                // Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
                // Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
            
            ArrayList Asaysayi = new ArrayList();
            ArrayList Asalolmayansayi = new ArrayList();

            for (int i = 1; i <= 20; i++)
            {
                
                Console.Write($"{i}. Sayıyı Giriniz : ");

                try
                {
                    uint Sayi = uint.Parse(Console.ReadLine());
                    if(Numara.Kontrol(Sayi))
                        Asaysayi.Add(Sayi);
                    else
                        Asalolmayansayi.Add(Sayi);
                }
                catch (FormatException)
                {
                    
                    throw new FormatException("Numeric Olmayan Karakter Girilemez.");
                    
                }
                catch(OverflowException)
                {
                    throw new OverflowException("Negatif Değer Girilemez. ");
                    
                }
            }

            Asaysayi.Sort();
            Asalolmayansayi.Sort();

            Print.ConsoleYaz(Asaysayi, "Asal Sayılar : ");
            Print.ConsoleYaz(Asalolmayansayi,"Asal Olmayan Sayılar : ");

            Console.WriteLine("Asal Sayılar : ");
            Print.Hesapla(Asaysayi);
            Console.WriteLine("Asalolmayan Sayılar : ");
            Print.Hesapla(Asalolmayansayi);
            Console.ReadKey();
         

        }
    }

    static class Print
    {
        internal static void ConsoleYaz(ArrayList list, string mesaj)
        {
            Console.WriteLine(mesaj);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        internal static void Hesapla(ArrayList list)
        {
            Console.WriteLine($"Dizinin Eleman Sayisi : {list.Count} \n" + 
            $"Dizinin Ortalaması : {OrtalamaHesap(list)}");
        }

        internal static double OrtalamaHesap(ArrayList list)
        {
            double Sonuc = 0;
            foreach (var item in list)
            {
                Sonuc += Convert.ToDouble(item); 
            }
            return Convert.ToDouble(Sonuc / (uint)list.Count);
        }

    }


    static class Numara
    {
        internal static bool Kontrol(uint Sayi)
        {
            if (Sayi == 1 || Sayi == 0)
            {
                return false;
            }
            for (int i = 2; i < Sayi; i++)
            {
                if(Sayi % i == 0)
                    return false;
                
            }

            return true;
        }



    }

}
