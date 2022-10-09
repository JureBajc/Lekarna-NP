using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekarna_NP
{
    public class SE_Mazilo:PO_Zdravilo
    {
        public int KolicinaMazila { get; set; }
        public enum PovrsinaAplikacije
        {
            obraz = 5,
            roka = 3,
            telo = 2,
            lokalno = 10
        }
        public PovrsinaAplikacije enota { get; set; }
        public int odmerek { get; set; }

        public override double steviloPreostalihDoziranj()
        {
            if (enota == PovrsinaAplikacije.telo)
            {
                return (KolicinaMazila / odmerek) * 0.5;
            }

            return (KolicinaMazila / odmerek) * (int)enota;
        }
        public override bool izdanoNaRecept()
        {
            return Recept;
        }

        public SE_Mazilo() : base()
        {

        }

        public SE_Mazilo(int kolicinaMazila, PovrsinaAplikacije enota, int odmerek, int id, List<Sestavine> sestavine, bool recept, string ime, double cena, string drzava_Pr, string naslov_dis, DateTime rok_trajanja) : base(sestavine, recept, ime, cena, drzava_Pr, naslov_dis, rok_trajanja)
        {
            this.KolicinaMazila = kolicinaMazila;
            this.enota = enota;
            this.odmerek = odmerek;
        }

    }
}