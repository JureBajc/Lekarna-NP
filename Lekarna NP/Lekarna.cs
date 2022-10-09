using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekarna_NP
{
    class Lekarna
    {
        public Lekarna(string naziv)
        {
            this.naziv = naziv;
        }

        public string naziv { get; set; }

        public delegate void Obvestilo(string a, string b);

        public event Obvestilo obvestilo;
        public void SporociloNarocnikom(string sporocilo)
        {
            obvestilo.Invoke(sporocilo, naziv);
        }
        public event Obvestilo Urnik;
        public void sporociloNarocnikom(string sporocilo)
        {
            Urnik.Invoke(sporocilo, naziv);
        }
    }
}