using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekarna_NP
{
    public class Sestavine
    {
        public string Ime { get; set; }
        public string Aktivna_snov { get; set; }
        public double Kolicina_vzdr { get; set; }
        public enum Enota
        {
            mg,
            ml,
            g,
            l,
            dag
        }
        public Enota enota { get; set; }


        public void IzpisPodatkov()
        {
            Console.WriteLine("ime: " + Ime + " Aktivne Snovi: " + Aktivna_snov+" Kolicina v zdravilu: "+Kolicina_vzdr+" Enota: "+enota);
        }
        public Sestavine()
        {

        }

        public Sestavine(string ime, string aktivna_snov, double kolicina_vzdr, Enota enota)
        {
            Ime = ime;
            Aktivna_snov = aktivna_snov;
            Kolicina_vzdr = kolicina_vzdr;
            this.enota = enota;
        }
    }
}