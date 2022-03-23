using System;
using System.Collections;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
            // her iki grubun kendi içerisinde ortalamalarını alan ve
            // bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız.
            // (Array sınıfını kullanarak yazınız.)

            
            ArrayList Dizi = new ArrayList();
            for (int i = 1; i <= 20; i++)
            {   
                
                Console.Write($" {i}. Sayıyı Giriniz : ");
                int Sayi = int.Parse(Console.ReadLine());
                Kontrol.NegatifSayi(Dizi,Sayi);
            }
            Dizi.Sort();
            ArrayList Enbuyuk = new ArrayList();
            ArrayList Enkucuk = new ArrayList();
            Bul.BuyukKucukSayi(Dizi,Enbuyuk,Enkucuk);
            Print.Yaz(Enbuyuk,Enkucuk);
            Bul.Ortalama(Enbuyuk,Enkucuk);
        }
    }


    static class Print
    {
        internal static void Yaz(ArrayList list1,ArrayList list2)
        {   
            Console.WriteLine("Girilen En büyük Sayıların Listesi : ");
            foreach (var buyuk in list1)
            {
                Console.WriteLine(buyuk);
            }

            Console.WriteLine("Girilen En Küçük Sayıların Listesi : ");
            foreach (var kucuk in list2)
            {
                Console.WriteLine(kucuk);
            }
        }

    }
    static class Bul
    {
        internal static void BuyukKucukSayi(ArrayList list,ArrayList list1, ArrayList list2)
        {
            int Sayac = 1;
            foreach (var item in list)
            {
                if (Sayac == 18 || Sayac == 19 || Sayac == 20)
                  list1.Add(item);  
                else if(Sayac == 1 || Sayac == 2 || Sayac == 3)
                    list2.Add(item);
                Sayac++;
            }
        }

        internal static void Ortalama(ArrayList list1,ArrayList list2)
        {
            double toplam1 = 0 ,toplam2 = 0;
            foreach (var buyuk in list1)
            {
                toplam1=toplam1+Convert.ToDouble(buyuk);
            }
            Console.WriteLine($"Girilen En Büyük Sayıların Ortalaması : {toplam1/3}");

            foreach (var kucuk in list2)
            {
                toplam2=toplam2+Convert.ToDouble(kucuk);
            }
            Console.WriteLine($"Girilen En Küçük Sayıların Ortalaması : {toplam2/3}");

        }

    }
    static class Kontrol
    {
        internal static void NegatifSayi(ArrayList Dizi, int Sayi)
        {
            if (Sayi < 0)
                Console.Write($"{Sayi} Negatif Değerdir.");
            else
                Dizi.Add(Sayi);
        }
    }
}
