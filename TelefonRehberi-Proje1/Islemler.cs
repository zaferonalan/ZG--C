using System;

namespace TelefonRehberi_Proje1
{
    public static class TelefonRehberi
    {
        public static void Menu(){
        // Giriş Bölümü
        Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz");
        Console.WriteLine("********************");
        Console.WriteLine("(1) Yeni Numara Kaydet");
        Console.WriteLine("(2) Varolan Numarayı Sil");
        Console.WriteLine("(3) Varolan Numarayı Güncelle");
        Console.WriteLine("(4) Rehberi Listele");
        Console.WriteLine("(5) Rehberde Arama Yap");
        Console.Write("Lütfen Seçiminizi Yapınız : ");

        }
        // Sayi kontrol bölümü
        public static bool SayiControl(int sayi)
        {
            if (sayi >= 1 && sayi <= 5)
                return true;
            else
                return false;
        }

        // Numara Kayıt
        public static void YeniKayit()
        {
            Console.Write("Lütfen İsmininizi Giriniz : ");
            string İsim = Console.ReadLine();
            Console.Write("Lütfen Soyisminizi Giriniz : ");
            string Soyisim = Console.ReadLine();
            Console.Write("Lütfen Numaranızı Giriniz : ");
            int Numara = int.Parse(Console.ReadLine());
            TelefonRehberiListe.RehberList.Add(new TelefonNumara(İsim,Soyisim,Numara));
            Console.WriteLine("Kayıt Başarılı");

        }

        public static void NumaraSil()
        {
            Console.Write("Lütfen Rehberden Silmek İstediğiniz Kişinin Adını Yada Soyadını Giriniz : ");
            string isim = Console.ReadLine();
            int sayac = 0;

            foreach (var item in TelefonRehberiListe.RehberList)
            {
                if (item.İsim.ToLower() == isim.ToLower() || item.Soyisim.ToLower() == isim.ToLower() )
                {
                    Console.Write("{0} isimli kişi silinmek üzere onaylıyormusunuz (Y/N) : ",isim);
                    char kontrol = char.Parse(Console.ReadLine());
                    if (kontrol == 'y')
                    {
                        int SilIndex = TelefonRehberiListe.RehberList.IndexOf(item);
                        TelefonRehberiListe.RehberList.RemoveAt(SilIndex);
                        sayac++;
                        Console.WriteLine("Silme İşlemi Başarılı.");
                        break;
                    }
                    else
                    {
                        sayac++;
                        Console.WriteLine("Silme İşlemi başarısız.");
                        break;
                    }
                }
            }
            if (sayac == 0)
            {
                Console.WriteLine("Rehberde aradığınız kişi bulunmamaktadır. Lütfen bir seçim yapınız");
                Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("Tekrar denemek için : (2)");
                Console.Write("Seçiminizi Giriniz : ");
                int secim = int.Parse(Console.ReadLine());
                if (secim == 2)
                {
                    while (secim == 2)
                    {
                        Console.Write("Lütfen Rehberden Silmek İstediğiniz Kişinin Adını yada Soyadını Giriniz :");
                        isim = Console.ReadLine();
                        foreach (var item2 in TelefonRehberiListe.RehberList)
                        {
                            if (item2.İsim.ToLower() == isim.ToLower() || item2.Soyisim.ToLower() == isim.ToLower())
                            {
                                Console.Write("{0} İsimli Kişi silinmek üzere onaylıyormusunuz (Y/N) : ",isim);
                                char kontrol = char.Parse(Console.ReadLine());

                                if (kontrol == 'y')
                                {
                                    sayac++;
                                    secim++;
                                    int SilIndex = TelefonRehberiListe.RehberList.IndexOf(item2);
                                    TelefonRehberiListe.RehberList.RemoveAt(SilIndex);
                                    Console.WriteLine("Silme İşlemi Başarılı.");
                                    break;
                                }
                                else
                                {
                                    secim++;
                                    Console.WriteLine("Silme İşlemi başarısız, Çıkılıyor...");
                                    break;
                                }
                            }
                        }

                        if (sayac == 0)
                        {
                            Console.WriteLine("Rehberde aradığınız kişi bulunmamaktadır. Lütfen bir seçim yapınız.");
                            Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                            Console.WriteLine("Tekrar denemek için : (2)");
                            Console.Write("Seçiminizi Giriniz : ");
                            secim = int.Parse(Console.ReadLine());
                        }

                    }
                }
            }
        }

        // Güncelleme işlemi
        public static void Guncelle()
        {
            Console.Write("Güncellemek istediğiniz kişinin adını giriniz : ");
            string isim = Console.ReadLine();
            int GuncelleKontrol = 0;
            int Count = TelefonRehberiListe.RehberList.Count;

            for (int i = 0; i < Count; i++)
            {
                if (TelefonRehberiListe.RehberList[i].İsim.ToLower() == isim.ToLower())
                {
                    Console.WriteLine("Kişinin Telefon Numarası : {0}", TelefonRehberiListe.RehberList[i].Numara);
                    Console.Write("Güncellemek istediğiniz telefon numarasını giriniz : ");
                    int YeniNum = int.Parse(Console.ReadLine());
                    TelefonRehberiListe.RehberList[i].Numara = YeniNum;
                    Console.WriteLine("Güncelleme Başarıyla Gerçekleşti");
                    GuncelleKontrol++;
                    break;
                }
            }
            if(GuncelleKontrol == 0)
            {
                Console.WriteLine("Aradığınız Kriterde bir kişi bulunmamaktadır.");
            }
        } 

        // RehberListeleme
        public static void RehberiListeleme()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("****************");

            for (int i = 0; i <= TelefonRehberiListe.RehberList.Count; i++)
            {
                Console.WriteLine("İsim : {0}",TelefonRehberiListe.RehberList[i].İsim);
                Console.WriteLine("Soyisim : {0}",TelefonRehberiListe.RehberList[i].Soyisim);
                Console.WriteLine("Numara : {0}",TelefonRehberiListe.RehberList[i].Numara);
            }
            
        }

        // Arama İslemi

        public static void Arama()
        {
            YenidenDene:
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("*******************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak (1) : ");
            Console.WriteLine("Telefon numarasına göre arama yapmak (2) : ");
            Console.Write("Seçiminizi Giriniz : ");
            int Secim = int.Parse(Console.ReadLine());

            if (Secim == 1)
            {
                Console.Write("Arama yapmak istediğiniz kişinin adını giriniz : ");
                string isim = Console.ReadLine();

                foreach (var item in TelefonRehberiListe.RehberList)
                {
                    if (item.İsim.ToLower() == isim.ToLower() || item.Soyisim.ToLower() == isim.ToLower())
                    {
                        Console.WriteLine("İsim : {0}",item.İsim);
                        Console.WriteLine("Soyisim : {0}", item.Soyisim);
                        Console.WriteLine("Numara : {0}", item.Numara);
                    }

                }
            }
            else if (Secim == 2)
            {
                Console.Write("Aramak istediğiniz kişinin telefon numarasını giriniz : ");
                int numara = int.Parse(Console.ReadLine());

                foreach (var item in TelefonRehberiListe.RehberList)
                {
                    if (item.Numara == numara)
                    {
                        Console.WriteLine("İsim : {0}",item.İsim);
                        Console.WriteLine("Soyisim : {0}", item.Soyisim);
                        Console.WriteLine("Numara : {0}", item.Numara);
                    }
                }
            }
            else
            {
                Console.WriteLine("Hatalı secim yaptınız tekrar deneyiniz.");
                goto YenidenDene;
            }

        }


    }
}