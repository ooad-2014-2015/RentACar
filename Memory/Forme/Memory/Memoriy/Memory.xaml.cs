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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Memoriy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public List<string> Uparene = new List<string>();
        public Image slika = new Image();
        



        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Window help = new Window();
            TextBlock tb = new TextBlock();
            tb.Text = "Ovo je neki tekst.";
            help.Height = 200;
            help.Width = 200;
            help.Background = Brushes.WhiteSmoke;
            help.Title = "Help button";
            help.Show();
            

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        bool dugme1=false;
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dugme1 = true;
            //slika.Source = "\cover.jpg";
           // button1.Foreground=
          
        }

        bool dugme9 = false;
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            dugme9 = true;

        }

     

    }
}
