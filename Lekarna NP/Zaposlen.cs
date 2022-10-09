using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekarna_NP
{
    class Zaposlen
    {
        public Zaposlen(string ime, string priimek, string delovenomesto)
        {
            this.ime = ime;
            this.priimek = priimek;
            this.delovenomesto = delovenomesto;
        }

        public string ime { get; set; }
        public string priimek { get; set; }
        public string delovenomesto { get; set; }



        public void PrijaviSeNaObvestilo(Lekarna a)
        {
            a.Urnik += sporocilo;
        }
        public void sporocilo(string sporocilo, string osebaIme)
        {
            Console.WriteLine("Lekarna FERI sporoča: 24.05. Skladišče: Janez Novak, Mešanje zdravil: Tina Meš, Blagajna na recept:");
        }
    }
}
