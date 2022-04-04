using System;

namespace Abstract_ornek
{
    public abstract class Otomobil{

        public int OtomobilKacTekerlek(){
            return 4;
        }

        public virtual Renk StandartRengiNe(){
            return Renk.Beyaz;
        }

        public abstract Marka HangiMarkanınAracı();

    }
   
}