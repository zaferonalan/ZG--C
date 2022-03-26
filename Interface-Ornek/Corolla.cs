namespace Interface_Ornek
{
    public class Corolla : IOtomobil
    {
        public Marka HangiMarkadanınAraci()
        {
            return Marka.Toyota;
        }

        public int KaçTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }

}