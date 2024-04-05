using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace kart_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<pracownicy> Pracownicy { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Dane();
        }

        private void Dane()
        {
            Pracownicy = new List<pracownicy>();
            StreamReader odczyt = new StreamReader("lista_pracownicy.txt");
            string naz_Nick = odczyt.ReadLine();
            string stanoWisko = odczyt.ReadLine();
            while (naz_Nick != null)
            {
                Pracownicy.Add(new pracownicy(naz_Nick, stanoWisko));
                naz_Nick = odczyt.ReadLine();
                stanoWisko = odczyt.ReadLine();
            }

            odczyt.Close();


        }
        private void ShowButton(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < Pracownicy.Count; i++)
            {
                if (Pracownicy[i].Nazwa == nick.Text)
                {
                    stanowiskoB.Text = Pracownicy[i].Stanowisko;
                    string zdj_Pracownika = Pracownicy[i].Nazwa + ".png";
                    grafika_stanowisko.Source = new BitmapImage(new Uri(zdj_Pracownika, UriKind.Relative));
                    break;
                }
                else
                {
                    stanowiskoB.Text = "BRAK";
                    grafika_stanowisko.Source = new BitmapImage(new Uri("brak.png", UriKind.Relative));   
                }
                
            }

        }


    }
}