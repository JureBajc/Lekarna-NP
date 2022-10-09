using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekarna_NP
{
    public class SE_Inhilator:PO_Zdravilo
    {
        public int st_V_Aplikacijo { get; set; }
        public int kol_Vpihov { get; set; }

        public SE_Inhilator() : base()
        {

        }

        public SE_Inhilator(int st_V_Aplikacijo, int kol_Vpihov, int id, List<Sestavine> sestavine, bool recept, string ime, double cena, string drzava_Pr, string naslov_dis, DateTime rok_trajanja) : base(sestavine, recept, ime, cena, drzava_Pr, naslov_dis, rok_trajanja)
        {
            this.st_V_Aplikacijo = st_V_Aplikacijo;
            this.kol_Vpihov = kol_Vpihov;
        }
        public override bool izdanoNaRecept()
        {
            return Recept;
        }

        public override double steviloPreostalihDoziranj()
        {
            return st_V_Aplikacijo / kol_Vpihov;
        }
    }
}