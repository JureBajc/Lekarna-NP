using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lekarna_NP
{
    public class PO_Racun
    {
        public PO_Racun(List<PO_Artikel> seznamartiklov, bool izdan,Oseba oseba)
        {
            this.seznamartiklov = seznamartiklov;
            this.izdan = izdan;
            this.oseba = oseba;
        }
        public PO_Racun()
        {

        }

        public PO_Racun(Oseba oseba)
        {
            this.oseba = oseba;
            Id = id_stevec;
            id_stevec++;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private static int id_stevec=0;
        public int id;
        public List<PO_Artikel> seznamartiklov { get; set; }
        public Oseba oseba { get; set; }
        public bool izdan { get; set; }

        public void odstraniartikel(PO_Artikel artikel)
        {
            try
            {
                bool exists = this.seznamartiklov.Remove(artikel);
                if (!exists)
                {
                    throw new ZdraviloNINaracunuException("ni na racunu");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void izdajRacun()
        {
            try
            {
                if (this.izdan)
                {
                    throw new RacunZeIdzanException("racune je ze izdan");
                }
                this.izdan = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }

 
    public class ZdraviloNINaracunuException : Exception
    {
        public ZdraviloNINaracunuException()
        {
        }

        public ZdraviloNINaracunuException(string message) : base(message)
        {
        }

        public ZdraviloNINaracunuException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ZdraviloNINaracunuException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
    public class RacunZeIdzanException : Exception
    {
        public RacunZeIdzanException()
        {
        }

        public RacunZeIdzanException(string message) : base(message)
        {
        }

        public RacunZeIdzanException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RacunZeIdzanException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
