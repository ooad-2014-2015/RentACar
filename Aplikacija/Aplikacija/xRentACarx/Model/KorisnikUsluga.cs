using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xRentACarx
{
    class KorisnikUsluga
    {
        //Varijable
        String ime, brojVozacke, vozackaIzdataOd, prebivaliste;
        DateTime datumRegistracije, istekVozacke;

        //Metode
        public String Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public String BrojVozacke
        {
            get { return brojVozacke; }
            set { brojVozacke = value; }
        }

        public String VozackaIzdataOd
        {
            get { return vozackaIzdataOd; }
            set { vozackaIzdataOd = value; }
        }

        public String Prebivaliste
        {
            get { return prebivaliste; }
            set { prebivaliste = value; }
        }
    }
}
