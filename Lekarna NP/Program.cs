using System;
using System.Collections.Generic;

namespace Lekarna_NP
{
    class Program
    {
        static void Main(string[] args)
        {

            List<PO_Artikel> zaloga = new();
            PO_Artikel artikel = new("Ampirin", 5.2, "Slovenija", "Herojev 14", DateTime.Today);
            zaloga.Add(artikel);
            //artikel.IzpisPodatkov();

            Sestavine sestavine = new("Aspirin", "2 - Acetoxybenzoic acid", 100, Sestavine.Enota.mg);
            List<Sestavine> sestavineList = new() { sestavine };

            //Console.WriteLine(artikel.SteviloPreostalihDni(new DateTime(2021, 3, 21, 0, 0, 0)));
            //Console.WriteLine(artikel.SteviloPreostalihDni(new DateTime(2022, 3, 21, 0, 0, 0)));
            //Console.WriteLine(artikel.SteviloPreostalihDni(new DateTime(2021, 3, 21, 0, 0, 0),new DateTime(2022, 3, 21, 0, 0, 0), "hladilnik"));
            //Console.WriteLine(artikel.SteviloPreostalihDni(new DateTime(2021, 3, 21, 0, 0, 0),new DateTime(2022, 3, 21, 0, 0, 0), "polica"));
            /*
                        SE_Ampula sE_Ampula = new(5);
                        //Console.WriteLine(sE_Ampula.steviloPreostalihDoziranj());

                        SE_Inhilator sE_Inhilator = new(6, 2);
                        //Console.WriteLine(sE_Inhilator.steviloPreostalihDoziranj());

                        SE_Raztopina sE_Raztopina = new(6, "natrijev klorid", 12, 4);
                        //Console.WriteLine(sE_Raztopina.steviloPreostalihDoziranj());

                        //SE_Mazilo sE_Mazilo = new(20, SE_Mazilo.PovrsinaAplikacije.lokalno, 10);
                        //Console.WriteLine(sE_Mazilo.steviloPreostalihDoziranj());

                        SE_Tableta sE_Tableta = new(8, 2);
                        //Console.WriteLine(sE_Tableta.steviloPreostalihDoziranj());


                        //PO_Artikel mazilo = new SE_Mazilo(20,SE_Mazilo.PovrsinaAplikacije.lokalno,20);
                        //PO_Artikel raztopina = new SE_Raztopina("raztopina", 20.00, "SLO", "tupatam", new DateTime("1-10-2024"), new Sestavina_zdravila[] { sestavina1 }, true, 12, 1.2, "ni topila", 10, 2);
                        //PO_Artikel inhalator = new SE_Inhilator("inhalator", 13.00, "SLO", "tupatam", new DateTime("1-10-2024"), new Sestavina_zdravila[] { sestavina1 }, true, 12, 8, 55);
                        PO_Artikel tableta = new SE_Tableta(10, 31);
                        PO_Artikel ampula = new SE_Ampula(10);
            */

            PO_Artikel Mazilo = new SE_Mazilo(1, SE_Mazilo.PovrsinaAplikacije.lokalno, 20, 10, sestavineList, true, "rak", 12.3, "SLO", "Naslov123", DateTime.Now);
            PO_Artikel Mazilo1 = new SE_Mazilo(2, SE_Mazilo.PovrsinaAplikacije.lokalno, 20, 10, sestavineList, true, "rak", 12.3, "SLO", "Naslov123", DateTime.Now);


            // List<PO_Racun> racunIz = new List<PO_Racun>();
            List<PO_Artikel> artikelNa = new List<PO_Artikel>();
            List<PO_RezerviranArtikel> rezerviraniArtikli = new List<PO_RezerviranArtikel>();


            Dictionary<int, PO_Racun> racunIz = new Dictionary<int, PO_Racun>();



            PO_Lekarna lekarna1 = new PO_Lekarna(new Dictionary<int, PO_Racun>(), artikelNa, racunIz, rezerviraniArtikli);

            Oseba oseba = new Oseba("Jure", "bajc", "moski", DateTime.Now, "bac@sdas", 1234567, true);


            lekarna1.rezervirajArtikel(Mazilo, oseba);

            lekarna1.ustvariRacun(oseba);

            List<PO_Artikel> test = new List<PO_Artikel> { Mazilo, Mazilo1 };

            lekarna1.dodajNaRacun(test, 0);


            lekarna1.sprostiRezervacijoArtikla(Mazilo, oseba);
            //lekarna1.sprostiRezervacijoArtikla(rezerviraniArtikli[0]);


            Console.WriteLine(lekarna1.kolicinaArtiklovNaZalogi(Mazilo));

            lekarna1.OdstraniArtikel(Mazilo);

            var print = lekarna1.VrniZadnjiDodanArtikel();
            Console.WriteLine(print);

            var printrac = lekarna1.NajdiRacun(0);

            lekarna1.rezervirajArtikel(Mazilo, oseba);
            lekarna1.ustvariRacun(oseba);


            lekarna1.DodajArtikel(Mazilo);
            lekarna1.dodajNaRacun(test, 1);
            //Console.WriteLine("Cena: " + cena);







            string podatki = @"C:\Users\jure.bajc\Documents\lakar\Jure_Bajc_Lekarna NP\Lekarna NP\podatki.csv";
            List<PO_Artikel> mojaZaloga = new List<PO_Artikel>();
            Inventar inventar1 = new Inventar(mojaZaloga);

            inventar1.beri(podatki);
            foreach (var item in mojaZaloga)
            {
                item.Izpis();
                Console.WriteLine("............................");
            }
            Console.WriteLine();
            inventar1.sortiranje(podatki);
            inventar1.sortiranjeV2(podatki);
            inventar1.isciTerOdstrani("Lekadol");
            Console.WriteLine("............................");
            Console.WriteLine("Artikel, ki je tik ob izteku roka: ");
            inventar1.artikelTikObIztekuRoka();
            Console.WriteLine("............................");




            List<PO_Artikel> Artikli_med_min_in_max_ceno(double min, double max)
            {
                List<PO_Artikel> artikli_ki_ustrezajo = zaloga.FindAll(item => item.Cena > min && item.Cena < max);
                return artikli_ki_ustrezajo;
            }


            Console.WriteLine("* Artikli_med_min_in_max_ceno(double min, double max)\n");
            double minCena = 3;
            double maxCena = 10;
            List<PO_Artikel> artikli_min_max_cena = Artikli_med_min_in_max_ceno(minCena, maxCena);
            Console.WriteLine("minimalna cena: " + minCena + " EUR\tmaksimalna cena: " + maxCena + " EUR");
            Console.WriteLine("\nArtikli, ki ustrezajo pogoju: ");
            foreach (var item in artikli_min_max_cena)
            {
                Console.WriteLine(" - " + item.Ime + ", " + item.Cena + " EUR");
            }

            List<PO_Artikel> Artikli_ki_v_imenu_vsebujejo_niz(string iskanNiz)
            {
                List<PO_Artikel> artikli_ki_ustrezajo = zaloga.FindAll(item => item.Ime.Contains(iskanNiz));
                return artikli_ki_ustrezajo;
            }

            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("* Artikli_ki_v_imenu_vsebujejo_niz(string iskanNiz)\n");
            string niz = "Am";
            List<PO_Artikel> ime_artikla_ima_niz = Artikli_ki_v_imenu_vsebujejo_niz(niz);
            Console.WriteLine("niz, ki ga mora vsebovati ime artikla: " + niz);
            Console.WriteLine("Artikli, ki vsebujejo niz: ");
            foreach (var item in ime_artikla_ima_niz)
            {
                Console.WriteLine(" - " + item.Ime);
            }


            List<PO_Artikel> Artikli_ki_so_proizvedeni_v_drzavi(string iskanaDrzava)
            {
                List<PO_Artikel> artikli_ki_ustrezajo = zaloga.FindAll(item => item.Drzava_Pr == iskanaDrzava);
                return artikli_ki_ustrezajo;
            }

            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("* Artikli_ki_so_proizvedeni_v_drzavi(string iskanaDrzava)\n");
            string drzava = "Slovenija";
            List<PO_Artikel> artikli_proizvedeni_v_drzavi = Artikli_ki_so_proizvedeni_v_drzavi(drzava);
            Console.WriteLine("Artikli, ki so proizvedeni v državi ('" + drzava + "'):");
            foreach (var item in artikli_proizvedeni_v_drzavi)
            {
                Console.WriteLine(" - " + item.Ime);
            }

            Console.WriteLine();


            Lekarna lekarna = new Lekarna("lekarna1");
            Zaposlen janko = new Zaposlen("janko", "koml", "linja");
            Stranka janez = new Stranka("janez","novak","janez.novak@gmail.com");
            janez.PrijaviSeNaObvestilo(lekarna);
            janko.PrijaviSeNaObvestilo(lekarna);

            lekarna.sporociloNarocnikom("rabim 1 tocko");
            lekarna.SporociloNarocnikom("rabim 1 tocko");
        }
    }
}