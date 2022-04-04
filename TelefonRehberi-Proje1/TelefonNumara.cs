namespace TelefonRehberi_Proje1
{
    public class TelefonNumara
    {
        //Bu kısımda Telefon Rehberimizdeki her bir kişi için isim, soyisim ve numara değişkenleri sabit olduğu için bir telefon rehberi modeli oluşturarak hepsinde kullanmalarını sağladık
        public TelefonNumara(string İsim, string Soyisim,int Numara)
        {
            //Bir Consturucter yardımıyla değişkinlerimizin atamasını gerçekleştirdik
            
            this.İsim = İsim;
            this.Soyisim = Soyisim;
            this.Numara = Numara;
        }

        public string İsim { get; set;}
        public string Soyisim { get; set; }
        public int Numara { get; set; }
    }
}