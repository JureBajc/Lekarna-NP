using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekarna_NP
{
    public abstract class PO_Zdravilo:PO_Artikel
    {
        private const bool V = true;

        public List<Sestavine> Sestavine { get; set; }
        public bool Recept { get; set; }

        public new virtual void IzpisPodatkov()
        {
            Console.WriteLine("Sestavine: ");

            for (int i = 0; i < Sestavine.Count; i++)
            {
                Console.WriteLine(Sestavine[i].Ime+" ");
            }

            Console.WriteLine();

            if (Recept = V)
            {
                Console.WriteLine("Na Recept");
            }
            else
            {
                Console.WriteLine("Brez Recepta");
            }
        }
        public override bool izdanoNaRecept()
        {
            return Recept;
        }
        public abstract double steviloPreostalihDoziranj();

        
        public PO_Zdravilo()
        {

        }

        protected PO_Zdravilo(List<Sestavine> sestavine, bool recept, string ime, double cena, string drzava_Pr, string naslov_dis, DateTime rok_trajanja) :base(ime,cena,drzava_Pr,naslov_dis,rok_trajanja)
        {
            this.Sestavine = sestavine;
            this.Recept = recept;
            Ime = ime;
            Cena = cena;
            Naslov_dis = naslov_dis;
            Rok_trajanja = rok_trajanja;
            
        }
    }
}