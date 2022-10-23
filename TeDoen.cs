using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Opdracht4
{
    internal class TeDoen
    {
        public int Id;

        public int Volgnummer()
        {
            return Interlocked.Increment(ref Id);
        }

        public string Titel { get; set; }

        public static int Counter;
        public DateTime? Tijdstip { get; set; }
        public string[] Informatie;
        public event TeDoenForm.Meedelen meedelen;

        public TeDoen(int id, string titel, DateTime tijdstip, string[] informatie)
        {
            Counter++;

            Id = Counter;

            if (tijdstip >= DateTime.Now)
            {
                Tijdstip = tijdstip;

            }
            else
            {
                Tijdstip = null;
            }

            Titel = titel;
            Informatie = informatie;
        }

        public override string ToString()

        {
            string result = "";

            foreach (string s in Informatie)
            {
                result += s.ToString() + "\n";

            }

            if (Tijdstip == null)
            {
                return "id" + Id + "\n title : " + Titel + "\n informatie : " + result;
            }
            else
            {
                return "id" + Id + " \n tijdstip: " + Tijdstip + "\n title : " + Titel + "\n informatie : " + result;
            }


        }

    }
}
