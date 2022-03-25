using System;

namespace ınheritance
{
   public class Hayvanlar:Canlılar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabiliri");
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
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuşlar uçarlar");
        }
    }
}