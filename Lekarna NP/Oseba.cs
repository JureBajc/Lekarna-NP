using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekarna_NP
{
    public class Oseba
    {
        public Oseba(string ime, string priimek, string spol, DateTime datumrojstva, string email, int stevilkaZdravstvenegaZavarovanja, bool osebaImaDodatnoZavarovanje)
        {
            this.ime = ime;
            this.priimek = priimek;
            this.spol = spol;
            this.datumrojstva = datumrojstva;
            this.email = email;
            this.stevilkaZdravstvenegaZavarovanja = stevilkaZdravstvenegaZavarovanja;
            this.osebaImaDodatnoZavarovanje = osebaImaDodatnoZavarovanje;
        }

        public string ime { get; set; }
        public string priimek { get; set; }
        public string spol { get; set; }
        public DateTime datumrojstva { get; set; }  
        public string email { get; set; }
        public int stevilkaZdravstvenegaZavarovanja { get; set; }
        public Boolean osebaImaDodatnoZavarovanje { get; set; }

        public bool osebiStaEnaki(Oseba oseba)
        {
            if (this.stevilkaZdravstvenegaZavarovanja == oseba.stevilkaZdravstvenegaZavarovanja)
                return true;
            return false;
        }
    }
}