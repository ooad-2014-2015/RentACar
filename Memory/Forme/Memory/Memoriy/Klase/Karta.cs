using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoriy.Klase
{
    class Karta
    {
        public enum stanje { Okrenuta,
                      Uparena,
                      Neokrenuta}
        private int x;
        private int y;
        public int kod;
        public stanje status;

        public Karta(int sifra)
        {
            kod = sifra;
        
        }

        int okreniNaPoledjinu()
        {
            this.status = stanje.Neokrenuta;
            return 0;
        }

        int okreniNaLice()
        {
            this.status = stanje.Okrenuta;
            return 1;
        }

        int Upari()
        {
            this.status = stanje.Uparena;
            return 2;
        }


    }
}
