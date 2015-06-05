using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Xps.Packaging;

namespace xRentACarx.ViewModel
{
    class HelpViewModel: INotifyPropertyChanged
    {
        private XpsDocument xps;

        public XpsDocument Xps
        {
            get { return xps; }
            set { xps = value; OnPropertyChanged("xps"); }
        }

        public HelpViewModel(DocumentViewer d)
        {
            Xps = new XpsDocument(@"C:\Users\AyLLa\Desktop\OOAD\xRentACarx\HELP.xps", System.IO.FileAccess.Read);
            d.Document = Xps.GetFixedDocumentSequence();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
