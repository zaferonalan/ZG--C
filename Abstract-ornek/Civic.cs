using System;

namespace Abstract_ornek
{
    public class Civic : Otomobil
    {
        public override Marka HangiMarkanınAracı()
        {
           return Marka.Honda;
        }
        public override Renk StandartRengiNe()
        {
            return Renk.Gri;
        }

    }

}