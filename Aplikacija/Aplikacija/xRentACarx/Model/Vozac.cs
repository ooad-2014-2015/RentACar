using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xRentACarx.Model
{
    class Vozac
    {
        //Varijable
        Int32 idVozaca;
        String imeVozaca;
        Boolean vozacZauzet;

        //Metode
        public Int32 IdVozaca
        {
            get { return idVozaca; }
            set { idVozaca = value; }
        }

        public Boolean VozacZauzet
        {
            get { return vozacZauzet; }
            set { vozacZauzet = value; }
        }
    }
}
