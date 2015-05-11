using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_A_Car
{
    class Iznajmljivanje: InterfaceZaPlacanje
    {

        //Varijable
        Int32 idIznajmljivanja, garazniBroj;
        enum tipIzajmljivanja
        {
            saVozacem,
            bezVozaca
        };
        enum lokacije
        {
            Sarajevo,
            Mostar,
            Zenica,
            Tuzla,
            BanjaLuka,
            Bijeljina
        };
        tipIzajmljivanja tip;
        DateTime datumIznajmljivanja, datumVracanja;
        Decimal cijena, popust, cijenaZaPlacanje;
        lokacije lokacijaPreuzimanja, lokacijaVracanja;
        Boolean potvrdaPlacanja;

        //Metode
       // Int32 izracunajBrojProteklihDana();
       //Decimal izracunajCijenuSaPopustom(Decimal popust);
       //Boolean potvrdiPlacanje();


    }
}
