using System;

namespace polymorphism_ve_sealed_class
{
   public class Hayvanlar:Canlılar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilir");
        }
        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Canlılar temasa tepki verir.");
        }
    }
    public class Sürüngenler:Hayvanlar{

        public Sürüngenler()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }

        public void SurunerekHareketEderler(){
            Console.WriteLine("Sürüngenler sürünerel hareker eder.");
        }
    }
    public class Kuslar:Hayvanlar{

        public Kuslar()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuşlar uçarlar");
        }
    }
}