using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;

namespace Rent_A_Car
{
    //Glavni VIewModel (parent) koji cuva ostale 
    class IznajmljivanjeViewModel: INotifyPropertyChanged
    {

        //Varijable
        public ICommand iznajmi { get; set; }
        private Iznajmljivanje iznajmljivanje;
        public Iznajmljivanje Iznajmljivanje
        {
            get { return iznajmljivanje; }
            set { iznajmljivanje = value; }
        }
        

        //View Modeli za ostale forme
        private LogInSesijaViewModel dijeteLoginSesijaViewModel;
        private PlacanjeViewModel dijetePlacanjeViewModel;
        private PracenjeGPSViewModel dijetePracenjeGPSViewModel;
        private RezervacijaViewModel dijeteRezervacijaViewModel;

        //Metode
        public IznajmljivanjeViewModel()
        {
            iznajmljivanje = new Iznajmljivanje();
        }


        

    }
}
