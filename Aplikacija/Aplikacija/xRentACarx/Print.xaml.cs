using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace xRentACarx
{
    /// <summary>
    /// Interaction logic for Print.xaml
    /// </summary>
    public partial class Print : Window
    {
        public Print()
        {
            InitializeComponent();
        }

        //kreiranje dokumenta
        private FlowDocument CreateFlowDocument()
        {
            // Kreiranje FlowDocument
            FlowDocument doc = new FlowDocument();
            Section sec = new Section();
            Paragraph p1 = new Paragraph();

            Bold bld = new Bold();
            bld.Inlines.Add(new Run("Ovo je tekst gdje treba nesto ispisati"));
            Italic italicBld = new Italic();
            italicBld.Inlines.Add(bld);
            Underline underlineItalicBld = new Underline();
            underlineItalicBld.Inlines.Add(italicBld);

            // Dodavanje osobina za paragraf
            p1.Inlines.Add(underlineItalicBld);

            // Dodavanje paragrafa u sekciju
            sec.Blocks.Add(p1);

            // Dodavanje sekcijeu FlowDocument
            doc.Blocks.Add(sec);

            return doc;
        }

        private void Printaj(object sender, RoutedEventArgs e)
        {
            try
            {
                PrintDialog printDlg = new PrintDialog();
                printDlg.PageRangeSelection = PageRangeSelection.AllPages;
                printDlg.UserPageRangeEnabled = true;
                var doPrint = printDlg.ShowDialog();
                if (doPrint != true)
                {
                    MessageBox.Show("nesto ne valja.");
                    return;
                }

                FlowDocument doc = CreateFlowDocument();
                doc.Name = "FlowDoc";

                IDocumentPaginatorSource idpSource = doc;

                // Slanje dokumenta printeru
                printDlg.PrintDocument(idpSource.DocumentPaginator, "Hello WPF Printing.");
            }
            catch
            {
                MessageBox.Show("Greška!");
            }
        }
    }
}
