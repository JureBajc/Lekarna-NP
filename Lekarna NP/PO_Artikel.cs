using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekarna_NP
{
    public class PO_Artikel
    {
        private int pravi_id;
        private static int stevec_id = 0;
        public string Ime { get; set; }
        public double Cena { get; set; }
        public string Drzava_Pr { get; set; }
        public string Naslov_dis { get; set; }
        public DateTime Rok_trajanja { get; set; }
        public enum tipSkladiscenja
        {
            Polica,
            Hladilnik
        }
        public tipSkladiscenja tipSkladiscanja {get;set;}
        


        public void IzpisPodatkov()
        {
            Console.WriteLine("ime: " + Ime + " cena:" + Cena);
        }
        public double SteviloPreostalihDni(DateTime datum)
        {
            TimeSpan a = (DateTime.Now.Subtract(datum));

            double b=Math.Truncate(Math.Round(a.TotalDays));

            return b;
        }

        public virtual void Izpis()
        {
            Console.WriteLine("ID: " + Id + "\n" + "Ime: " + Ime + "\n" + "Cena: " + Cena + "\n" + "Drzava: " + Drzava_Pr + "\n" + "Naslov: " + Naslov_dis + "\n" + "Rok: " + Rok_trajanja);
        }
        /*
        public double SteviloPreostalihDni(DateTime datum,DateTime rok, string tipSkladiscenja)
        {
            TimeSpan a;
            double b;
            if (tipSkladiscenja == "hladilnik")
            {
                a = (rok.Subtract(datum));
                b = Math.Truncate(Math.Round(a.TotalDays));

                return Math.Round(b * 1.5);
            }
            if (tipSkladiscenja == "polica")
            {
                a = (rok.Subtract(datum));
                b = Math.Truncate(Math.Round(a.TotalDays));

                return b;
            }

            a = (rok.Subtract(datum));
            b = Math.Truncate(Math.Round(a.TotalDays));
            return b;
        }
        */
        public virtual bool izdanoNaRecept()
        {
            return false;
        }

        public int Id
        {
            get { return pravi_id; }
            set { pravi_id = value; }
        }

        public PO_Artikel()
        {
            Id = stevec_id;
            stevec_id++;
        }

        public PO_Artikel(string ime, double cena, string drzava_Pr, string naslov_dis, DateTime rok_trajanja)
        {
            Ime = ime;
            Cena = cena;
            Drzava_Pr = drzava_Pr;
            Naslov_dis = naslov_dis;
            Rok_trajanja = rok_trajanja;
        }
    }
}
