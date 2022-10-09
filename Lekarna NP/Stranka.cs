using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekarna_NP
{
    class Stranka
    {
        public Stranka(string ime, string priimek, string email)
        {
            this.ime = ime;
            this.priimek = priimek;
            this.email = email;
        }

        public string ime { get; set; }
        public string priimek { get; set; }
        public string email { get; set; }



		public void PrijaviSeNaObvestilo(Lekarna a)
		{
            a.obvestilo += sporocilo;
		}

		public void sporocilo(string sporocilo, string osebaIme)
		{
			Console.WriteLine("Lekarna FERI sporoča: Pred poletjem poskrbite za vašo kožo! Jutri vse sončne kreme 20% znižane! Prejmenik");
		}
	}
}
