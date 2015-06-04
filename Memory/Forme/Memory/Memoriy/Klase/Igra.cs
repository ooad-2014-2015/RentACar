using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoriy.Klase
{
    class Igra
    {
        Ploca p = new Ploca();
        List<Karta> K = new List<Karta>();

        public Igra(Ploca ploca, List<Karta> k)
        {
            p = ploca;
            K = k;
        }



    }
}
