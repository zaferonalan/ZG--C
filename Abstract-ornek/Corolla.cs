using System;

namespace Abstract_ornek
{
    public class Corolla : Otomobil
    {
        public override Marka HangiMarkanınAracı()
        {
            return Marka.Toyota;
        }
    }
}