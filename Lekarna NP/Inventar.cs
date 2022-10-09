using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lekarna_NP
{
    internal class Inventar
    {

        List<PO_Artikel> zaloga = new List<PO_Artikel>();
        public Inventar(List<PO_Artikel> zunanjaZaloga)
        {
            this.zaloga = zunanjaZaloga;
        }
        public void beri(string pot)
        {
            string[] vrste = File.ReadAllLines(pot);

            for (int i = 1; i < vrste.Length; i++)
            {
                var index = vrste[i].Split(';');

                for (int j = 0; j < index.Length; j++)
                {
                    index[j] = index[j].Trim();
                }
                switch (index[0])
                {
                    case "Ampula":
                        {
                            SE_Ampula ampula = new SE_Ampula();
                            ampula.Id = Convert.ToInt32(index[1]);
                            ampula.Ime = (string)index[2];
                            ampula.Cena = Convert.ToDouble(index[3]);
                            ampula.Drzava_Pr = (string)index[4];
                            ampula.Naslov_dis = (string)index[5];
                            ampula.Rok_trajanja = Convert.ToDateTime(index[6]);
                            ampula.tipSkladiscanja = (PO_Artikel.tipSkladiscenja)Enum.Parse(typeof(PO_Artikel.tipSkladiscenja), (string)index[7]);
                            List<Sestavine> seznamSestavin = new List<Sestavine>();
                            Sestavine sestavina = new Sestavine
                            {
                                Ime = (string)index[22],
                                Aktivna_snov = (string)index[23],
                                Kolicina_vzdr = Convert.ToDouble(index[25]),
                                enota = (Sestavine.Enota)Enum.Parse(typeof(Sestavine.Enota), (string)index[24])
                            };
                            seznamSestavin.Add(sestavina);
                            ampula.Sestavine = seznamSestavin;
                            ampula.Recept = Convert.ToBoolean(index[8]);
                            ampula.Rok_trajanja = Convert.ToDateTime(index[9]);
                            ampula.kol_Ampul = Convert.ToInt32(index[10]);
                            zaloga.Add(ampula);
                        }
                        break;

                    case "Tableta":
                        {
                            SE_Tableta tableta = new SE_Tableta();
                            tableta.Id = Convert.ToInt32(index[1]);
                            tableta.Ime = (string)index[2];
                            tableta.Cena = Convert.ToDouble(index[3]);
                            tableta.Drzava_Pr = (string)index[4];
                            tableta.Naslov_dis = (string)index[5];
                            tableta.Rok_trajanja = Convert.ToDateTime(index[6]);
                            tableta.tipSkladiscanja = (PO_Artikel.tipSkladiscenja)Enum.Parse(typeof(PO_Artikel.tipSkladiscenja), (string)index[7]);
                            List<Sestavine> seznamSestavin = new List<Sestavine>();
                            Sestavine sestavina = new Sestavine
                            {
                                Ime = (string)index[22],
                                Aktivna_snov = (string)index[23],
                                Kolicina_vzdr = Convert.ToDouble(index[25]),
                                enota = (Sestavine.Enota)Enum.Parse(typeof(Sestavine.Enota), (string)index[24])
                            };
                            seznamSestavin.Add(sestavina);
                            tableta.Sestavine = seznamSestavin;
                            tableta.Recept = Convert.ToBoolean(index[8]);
                            tableta.Rok_trajanja = Convert.ToDateTime(index[9]);
                            tableta.st_Pakiranje = Convert.ToInt32(index[11]);
                            tableta.st_Aplikacija = Convert.ToInt32(index[12]);
                            zaloga.Add(tableta);
                        }
                        break;

                    case "Mazilo":
                        {
                            SE_Mazilo mazilo = new SE_Mazilo();
                            mazilo.Id = Convert.ToInt32(index[1]);
                            mazilo.Ime = (string)index[2];
                            mazilo.Cena = Convert.ToDouble(index[3]);
                            mazilo.Drzava_Pr = (string)index[4];
                            mazilo.Naslov_dis = (string)index[5];
                            mazilo.Rok_trajanja = Convert.ToDateTime(index[6]);
                            mazilo.tipSkladiscanja = (PO_Artikel.tipSkladiscenja)Enum.Parse(typeof(PO_Artikel.tipSkladiscenja), (string)index[7]);
                            List<Sestavine> seznamSestavin = new List<Sestavine>();
                            Sestavine sestavina = new Sestavine
                            {
                                Ime = (string)index[22],
                                Aktivna_snov = (string)index[23],
                                Kolicina_vzdr = Convert.ToDouble(index[25]),
                                enota = (Sestavine.Enota)Enum.Parse(typeof(Sestavine.Enota), (string)index[24])
                            };
                            seznamSestavin.Add(sestavina);
                            mazilo.Sestavine = seznamSestavin;
                            mazilo.Recept = Convert.ToBoolean(index[8]);
                            mazilo.Rok_trajanja = Convert.ToDateTime(index[9]);
                            mazilo.KolicinaMazila = Convert.ToInt32(index[13]);
                            mazilo.enota = (SE_Mazilo.PovrsinaAplikacije)Enum.Parse(typeof(SE_Mazilo.PovrsinaAplikacije), index[14]);
                            mazilo.odmerek = Convert.ToInt32(index[15]);
                            zaloga.Add(mazilo);
                        }
                        break;
                    case "Raztopina":
                        {
                            SE_Raztopina raztopina = new SE_Raztopina();
                            raztopina.Id = Convert.ToInt32(index[1]);
                            raztopina.Ime = (string)index[2];
                            raztopina.Cena = Convert.ToDouble(index[3]);
                            raztopina.Drzava_Pr = (string)index[4];
                            raztopina.Naslov_dis = (string)index[5];
                            raztopina.Rok_trajanja = Convert.ToDateTime(index[6]);
                            raztopina.tipSkladiscanja = (PO_Artikel.tipSkladiscenja)Enum.Parse(typeof(PO_Artikel.tipSkladiscenja), (string)index[7]);
                            List<Sestavine> seznamSestavin = new List<Sestavine>();
                            Sestavine sestavina = new Sestavine
                            {
                                Ime = (string)index[22],
                                Aktivna_snov = (string)index[23],
                                Kolicina_vzdr = Convert.ToDouble(index[25]),
                                enota = (Sestavine.Enota)Enum.Parse(typeof(Sestavine.Enota), (string)index[24])
                            };
                            seznamSestavin.Add(sestavina);
                            raztopina.Sestavine = seznamSestavin;
                            raztopina.Recept = Convert.ToBoolean(index[8]);
                            raztopina.Rok_trajanja = Convert.ToDateTime(index[9]);
                            raztopina.Koncentracija = Convert.ToDouble(index[16]);
                            raztopina.Topilo = index[17];
                            raztopina.SkupnaKolicina = Convert.ToInt32(index[18]);
                            raztopina.Odmerek = Convert.ToInt32(index[19]);
                            zaloga.Add(raztopina);
                        }
                        break;
                    case "Inhilator":
                        {
                            SE_Inhilator inhalator = new SE_Inhilator();
                            inhalator.Id = Convert.ToInt32(index[1]);
                            inhalator.Ime = (string)index[2];
                            inhalator.Cena = Convert.ToDouble(index[3]);
                            inhalator.Drzava_Pr = (string)index[4];
                            inhalator.Naslov_dis = (string)index[5];
                            inhalator.Rok_trajanja = Convert.ToDateTime(index[6]);
                            inhalator.tipSkladiscanja = (PO_Artikel.tipSkladiscenja)Enum.Parse(typeof(PO_Artikel.tipSkladiscenja), (string)index[7]);
                            List<Sestavine> seznamSestavin = new List<Sestavine>();
                            Sestavine sestavina = new Sestavine
                            {
                                Ime = (string)index[22],
                                Aktivna_snov = (string)index[23],
                                Kolicina_vzdr = Convert.ToDouble(index[25]),
                                enota = (Sestavine.Enota)Enum.Parse(typeof(Sestavine.Enota), (string)index[24])
                            };
                            seznamSestavin.Add(sestavina);
                            inhalator.Sestavine = seznamSestavin;
                            inhalator.Recept = Convert.ToBoolean(index[8]);
                            inhalator.Rok_trajanja = Convert.ToDateTime(index[9]);
                            inhalator.st_V_Aplikacijo = Convert.ToInt32(index[20]);
                            inhalator.kol_Vpihov = Convert.ToInt32(index[21]);
                            zaloga.Add(inhalator);
                        }
                        break;
                }
            }
        }
        public void isciTerOdstrani(string iskanoIme)
        {
            var iskanoZdravilo = zaloga.FindAll(x => x.Ime == iskanoIme);
            zaloga.RemoveAll(x => x.Ime == iskanoIme);
            foreach (var zdravilo in iskanoZdravilo)
                Console.WriteLine("Odstranjen je bil: {0}", zdravilo.Ime);
        }

        public void artikelTikObIztekuRoka()
        {
            zaloga.OrderBy(x => x.Rok_trajanja);
            zaloga[0].Izpis();
            zaloga.RemoveAt(0);
        }

        public void dodajPoljubnoZdravilo(PO_Artikel zdravilo)
        {
            zaloga.Add(zdravilo);
            Console.WriteLine("Dodano je bilo zdravilo: \n");
            zdravilo.Izpis();
        }
        public void sortiranje(string pot)
        {  
        string[] lines = File.ReadAllLines(pot);
            IEnumerable<string> query =
            from line in lines
            let x = line.Split(';')
            orderby x[0],x[2]
            select x[0] + ";" + x[1] +";"+ x[2]+ ";" + x[3] + ";" + x[4] + ";" + x[5] + ";" + x[6] + ";" + x[7] + ";" + x[8] + ";" + x[9] + ";" + x[10] + ";" + x[11] + ";" + x[12] + ";" + x[13] + ";" + x[14] + ";" + x[15] + ";" + x[16] + ";" + x[17] + ";" + x[18] + ";" + x[19] + ";" + x[20] + ";" + x[21] + ";" + x[22] + ";" + x[23] + ";" + x[24] + ";" + x[25];

        File.WriteAllLines(@"../../../sortiranoV2.csv", query.ToArray());  
  
        Console.WriteLine("Je bilo sortirano");  
        Console.ReadKey();  
    }

        public void sortiranjeV2(string pot)
        {
            var lines = File.ReadLines(pot);
            var lineCount1 = File.ReadAllLines(pot).Length;
            List<ArrayList> test = new List<ArrayList>();
            int k = 0;
            foreach (var line in lines)
            {
                string[] besede = line.Split(';', StringSplitOptions.RemoveEmptyEntries);
                ArrayList arlist = new ArrayList();

                for (int i = 0; i < besede.Length; i++)
                {
                    arlist.Add(besede[i]);
                }
                test.Add(arlist);
            }
            List<ArrayList> sorted = test.OrderBy(x => x[0])
                                    .ThenBy(x => x[2])
                                    .ToList();
            Console.WriteLine(sorted[0].ToString());
        }
        public void preberiFile(string pot)
        {
            try
            {
                if (!pot.EndsWith(".csv")){
                    throw new CSVDatotekaNapacneOblikeException("Napacen format");
                }
            }
            catch (CSVDatotekaNapacneOblikeException e)
            {
                Console.WriteLine(e);
            }
        }

            /*
            string[] datums = test.Split('.', StringSplitOptions.RemoveEmptyEntries);
            Datum datum = new Datum(value, int.Parse(datums[0]), int.Parse(datums[1]), int.Parse(datums[2]));

            var lineCount = File.ReadAllLines(pot).Length;
            Prisotnost[] prisotnosti = new Prisotnost[lineCount];
            for (int i = 0; i < prisotnosti.Length; i++)
            {
                Prisotnost prisotnost0 = new Prisotnost(value, datum, int.Parse((string)arlist[5]), PretvoriTipDela((string)(arlist[6])));
                prisotnosti[i] = prisotnost0;
            }

            osebe[k] = new Oseba(long.Parse((string)arlist[0]), (arlist[1]).ToString(), (arlist[2]).ToString(), datum, prisotnosti);
            k++;
            */

        }

    public class CSVDatotekaNapacneOblikeException : Exception
    {
        public CSVDatotekaNapacneOblikeException()
        {
        }

        public CSVDatotekaNapacneOblikeException(string message) : base(message)
        {
        }

        public CSVDatotekaNapacneOblikeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CSVDatotekaNapacneOblikeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}