using System;

namespace Abstract_ornek
{
    public class Focus : Otomobil
    {
        public override Marka HangiMarkanınAracı()
        {
            return Marka.Ford;
        }
    }
}