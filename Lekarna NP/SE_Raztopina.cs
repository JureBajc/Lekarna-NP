using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekarna_NP
{
    public class SE_Raztopina:PO_Zdravilo
    {
        public double Koncentracija { get; set; }
        public string Topilo { get; set; }
        public int SkupnaKolicina { get; set; }
        public int Odmerek { get; set; }


        public SE_Raztopina() : base()
        {

        }

        public SE_Raztopina(double koncentracija, string topilo, int skupnaKolicina, int odmerek, List<Sestavine> sestavine, bool recept, string ime, double cena, string drzava_Pr, string naslov_dis, DateTime rok_trajanja) : base(sestavine, recept, ime, cena, drzava_Pr, naslov_dis, rok_trajanja)
        {
            Koncentracija = koncentracija;
            Topilo = topilo;
            SkupnaKolicina = skupnaKolicina;
            Odmerek = odmerek;
        }
        public override bool izdanoNaRecept()
        {
            return Recept;
        }

        public override double steviloPreostalihDoziranj()
        {
            return (SkupnaKolicina / Odmerek) * Koncentracija;
        }
    }
}