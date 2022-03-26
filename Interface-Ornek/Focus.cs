namespace Interface_Ornek
{
    public class Focus : IOtomobil
    {
        public Marka HangiMarkadanınAraci()
        {
            return Marka.Ford;
        }

        public int KaçTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }
    }
}