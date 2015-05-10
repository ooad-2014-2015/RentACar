using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_A_Car
{
    class Rezervacije
    {

        //Varijable
        enum lokacije
        {
            Sarajevo,
            Mostar,
            Zenica,
            Tuzla,
            BanjaLuka,
            Bijeljina
        };
        enum tipIzajmljivanja
        {
            saVozacem,
            bezVozaca
        };
        Int32 idRezervacije;
        tipIzajmljivanja tip;
        DateTime datumRezervacije, datumIznajmljivanja, datumVracanjaVozila;
        lokacije lokacijaPreuzimanja, lokacijaVracanja;

    }
}
