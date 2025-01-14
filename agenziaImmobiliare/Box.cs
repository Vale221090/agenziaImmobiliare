using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenziaImmobiliare
{
    public class Box : Immobili
    {
        public int PostiAuto { get; set; }

        public Box(string codice, string indirizzo, int cap, string citta, int superficie, int utentiInteressati, int postiAuto) : base(codice, indirizzo, cap, citta, superficie, utentiInteressati)
        {
            PostiAuto = postiAuto;
        }
        public void AggiungiBox(string codice, string indirizzo, int cap, string citta, int superficie, int utentiInteressati, int postiAuto)
        {
            Codice = codice;
            Indirizzo = indirizzo;
            Cap = cap;
            Citta = citta;
            Superficie = superficie;
            UtentiInteressati = utentiInteressati;
            PostiAuto = postiAuto;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nPosti auto: {PostiAuto}";
        }
    }
}
