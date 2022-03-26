namespace Interface_Ornek
{
    public class Civic : IOtomobil
    {
        public Marka HangiMarkadanınAraci()
        {
           return Marka.Honda;
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