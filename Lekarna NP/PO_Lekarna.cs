using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekarna_NP
{
    internal class PO_Lekarna : ILekarna
    {
        public Dictionary<int, PO_Racun> seznam_racunov = new Dictionary<int, PO_Racun>();
        List<PO_Artikel> artikli_na_zalogi = new List<PO_Artikel>();

        public PO_Lekarna(Dictionary<int, PO_Racun> seznam_racunov, List<PO_Artikel> artikelNa, Dictionary<int, PO_Racun> racunIz, List<PO_RezerviranArtikel> rezerviran_artikel)
        {
            this.seznam_racunov = seznam_racunov;
            this.artikelNa = artikelNa;
            this.racunIz = racunIz;
            this.rezerviran_artikel = rezerviran_artikel;
        }

        public List<PO_Artikel> artikelNa { get; set; }
        public Dictionary<int, PO_Racun> racunIz { get; set; }
        public List<PO_RezerviranArtikel> rezerviran_artikel { get; set; }


        public Dictionary<int, PO_Racun> Seznam_izdanih
        {
            get { return racunIz; }
            set { racunIz = value; }
        }
        public Dictionary<int, PO_Racun> Seznam_racunov
        {
            get { return racunIz; }
            set { racunIz = value; }
        }


        public bool artikelNaZalogi(PO_Artikel artikel)
        {
            foreach (PO_Artikel x in artikelNa)
            {
                if (artikel.Ime == x.Ime)
                {
                    return true;
                }
            }
            return false;
        }
        public void ustvariRacun(Oseba oseba)
        {
            PO_Racun racun = new PO_Racun(new List<PO_Artikel>(), false, oseba);
            seznam_racunov[racun.Id] = racun;
        }

        public void dodajNaRacun(List<PO_Artikel> seznamArtiklov, int racid)
        {
            PO_Racun? racun = NajdiRacun(racid);
            if (racun == null)
            {
                return;
            }

            for (int i = 0; i < seznamArtiklov.Count(); i++)
            {
                for (int j = 0; j < artikli_na_zalogi.Count(); j++)
                {
                    if (seznamArtiklov[i].Ime == artikli_na_zalogi[j].Ime)
                    {
                        racun.seznamartiklov.Add(artikli_na_zalogi[j]);
                        artikli_na_zalogi.RemoveAt(j);
                        break;
                    }
                }
            }
        }

        public void izdajRacun(Oseba oseba, int idrac)
        {
            Seznam_racunov[idrac].oseba = oseba;
            Seznam_racunov[idrac].izdan = true;
            Seznam_izdanih.Add(idrac, Seznam_racunov[idrac]);
        }

        public double izracunajCeno(int idrac)
        {
            double cena = 0;
            if (Seznam_racunov[idrac].oseba.osebaImaDodatnoZavarovanje == true)
            {
                foreach (PO_Artikel x in Seznam_racunov[idrac].seznamartiklov)
                {
                    if (x is PO_Zdravilo)
                    {
                        PO_Zdravilo zdravilo = (PO_Zdravilo)x;
                        if (zdravilo.izdanoNaRecept() == true)
                        {
                            cena += 0;
                        }
                        else
                        {
                            cena += zdravilo.Cena;
                        }
                    }
                    else
                    {
                        cena += x.Cena;
                    }
                }

            }
            else
            {
                foreach (PO_Artikel x in Seznam_racunov[idrac].seznamartiklov)
                {
                    if (x is PO_Zdravilo)
                    {
                        PO_Zdravilo zdravilo = (PO_Zdravilo)x;
                        if (zdravilo.izdanoNaRecept() == true)
                        {
                            cena += zdravilo.Cena * 0.2;
                        }
                        else
                        {
                            cena += zdravilo.Cena;
                        }
                    }
                    else
                    {
                        cena += x.Cena;
                    }
                }
            }
            return cena;
        }

        public int kolicinaArtiklovNaZalogi(PO_Artikel artikel)
        {
            int st = 0;
            foreach (PO_Artikel x in artikelNa)
            {
                if (x.Ime == x.Ime)
                {
                    st++;
                }
            }
            return st;
        }

        public void rezervirajArtikel(PO_Artikel artikel, Oseba oseba)
        {
            artikelNa.Remove(artikel);
            rezerviran_artikel.Add(new PO_RezerviranArtikel(artikel, oseba));
        }

        public void sprostiRezervacijoArtikla(PO_Artikel artikel, Oseba oseba)
        {
            foreach (PO_RezerviranArtikel x in rezerviran_artikel)
            {
                if (x.artikel == artikel && x.oseba == oseba)
                {
                    PO_Artikel a = x.artikel;
                    artikelNa.Add(a);
                    rezerviran_artikel.Remove(x);
                    break;
                }
            }
        }
        public void sprostiRezervacijoArtikla(PO_RezerviranArtikel rezerviranArtikel)
        {
            foreach (PO_RezerviranArtikel x in rezerviran_artikel)
            {
                if (rezerviranArtikel.artikel == x.artikel)
                {
                    PO_Artikel a = x.artikel;
                    artikelNa.Add(a);
                    rezerviran_artikel.Remove(x);
                    break;
                }
            }
        }

        public void DodajArtikel(PO_Artikel artikel)
        {
            artikelNa.Add(artikel);
        }

        public void OdstraniArtikel(PO_Artikel artikel)
        {

            if (artikelNa.Contains(artikel))
            {
                while (artikelNa.Contains(artikel))
                {
                    artikelNa.Remove(artikel);
                }

            }
        }

        public PO_Artikel VrniZadnjiDodanArtikel()
        {
            if (artikelNa.Count != 0)
            {
                return artikelNa.Last();
            }
            else 
            { 
                return null; 
            }
        }


        public PO_Racun? NajdiRacun(int racid)
        {
            if (seznam_racunov.ContainsKey(racid))
            {
                return seznam_racunov[racid];
            }
            return null;
        }

        void ILekarna.ustvariRacun(Oseba oseba)
        {
            throw new NotImplementedException();
        }

        void ILekarna.izdajRacun(PO_Racun racun)
        {
            throw new NotImplementedException();
        }

        double ILekarna.izracunajCeno(PO_Racun racun)
        {
            throw new NotImplementedException();
        }

        /*/ public void DodajArtikel - doda nov artikel v zalogo Lekarni
public void OdstraniArtikel– odstrani artikel iz zaloge
public VrniZadnjiDodanArtikel – vrne zadnji dodan artikel
/*/


    }
}