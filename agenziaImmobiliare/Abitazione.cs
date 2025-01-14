using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenziaImmobiliare
{
    public class Abitazione : Immobili
    {
        public int NumeroVani { get; set; }
        public int NumeroBagni { get; set; }

        public Abitazione(string codice, string indirizzo, int cap, string citta, int superficie, int utentiInteressati, int numeroVani, int numeroBagni) : base(codice, indirizzo, cap, citta, superficie, utentiInteressati)
        {
            NumeroVani = numeroVani;
            NumeroBagni = numeroBagni;
        }
        public void AggiungiAbitazione(string codice, string indirizzo, int cap, string citta, int superficie, int utentiInteressati, int numeroVani, int numeroBagni)
        {
            Codice = codice;
            Indirizzo = indirizzo;
            Cap = cap;
            Citta = citta;
            Superficie = superficie;
            NumeroVani = numeroVani;
            NumeroBagni = numeroBagni;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nNumero vani: {NumeroVani}\nNumero bagni: {NumeroBagni}";
        }
    }
}
