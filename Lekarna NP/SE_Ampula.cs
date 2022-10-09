using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekarna_NP
{
    public class SE_Ampula:PO_Zdravilo
    {
        public int kol_Ampul { get; set; }


        public SE_Ampula():base()
        {

        }
        public SE_Ampula(int kol_Ampul, List<Sestavine> sestavine, bool recept, string ime, double cena, string drzava_Pr, string naslov_dis, DateTime rok_trajanja) : base(sestavine, recept, ime, cena, drzava_Pr, naslov_dis, rok_trajanja)
        {
            this.kol_Ampul = kol_Ampul;
        }
        public override bool izdanoNaRecept()
        {
            return Recept;
        }

        public override double steviloPreostalihDoziranj()
        {
            return kol_Ampul;
        }
    }
}