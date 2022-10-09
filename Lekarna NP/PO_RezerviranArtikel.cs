using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekarna_NP
{
    public class PO_RezerviranArtikel
    {
        public PO_RezerviranArtikel(PO_Artikel artikel, Oseba oseba)
        {
            this.artikel = artikel;
            this.oseba = oseba;
        }

        public PO_Artikel artikel { get; set; }
        public Oseba oseba { get; set; }
    }
}
