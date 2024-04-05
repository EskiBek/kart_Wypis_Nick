using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kart_
{
    public class pracownicy
    {
        public string Nazwa { get; set; }
        public string Stanowisko { get; set; }

        public pracownicy(string nazwa, string stanowisko)
        {
            Nazwa = nazwa;
            Stanowisko = stanowisko;
        }
    }
}
