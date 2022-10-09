using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekarna_NP
{
    public class SE_Tableta:PO_Zdravilo
    {
        public int st_Pakiranje { get; set; }
        public int st_Aplikacija { get; set; }

        public SE_Tableta() : base()
        {

        }

        public SE_Tableta(int st_Pakiranje, int st_Aplikacija, List<Sestavine> sestavine, bool recept, string ime, double cena, string drzava_Pr, string naslov_dis, DateTime rok_trajanja) : base(sestavine, recept, ime, cena, drzava_Pr, naslov_dis, rok_trajanja)
        {
            this.st_Pakiranje = st_Pakiranje;
            this.st_Aplikacija = st_Aplikacija;
        }

        public override void IzpisPodatkov()
        {
            Console.WriteLine("Stevilo tablet v pakiranju: " + this.st_Pakiranje + " Stevilo tablet na aplikacijo: " + this.st_Aplikacija);

        }
        public override bool izdanoNaRecept()
        {
            return Recept;
        }

        public override double steviloPreostalihDoziranj()
        {
            return this.st_Pakiranje / this.st_Aplikacija;
        }
    }
}