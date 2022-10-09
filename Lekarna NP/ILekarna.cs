using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekarna_NP
{
    public interface ILekarna
    {
        void rezervirajArtikel(PO_Artikel artikel, Oseba oseba);

        void ustvariRacun(Oseba oseba);
        void dodajNaRacun(List<PO_Artikel> seznamArtiklov, int racid);
        void izdajRacun(PO_Racun racun);
        void sprostiRezervacijoArtikla(PO_Artikel artikel, Oseba oseba);
        void sprostiRezervacijoArtikla(PO_RezerviranArtikel rezerviranArtikel);
        int kolicinaArtiklovNaZalogi(PO_Artikel artikel);
        bool artikelNaZalogi(PO_Artikel artikel);
        double izracunajCeno(PO_Racun racun);
    }
}
