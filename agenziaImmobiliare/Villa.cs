using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenziaImmobiliare
{
    public class Villa : Immobili
    {
        public int SuperficieGiardino { get; set; }


        public Villa(string codice, string indirizzo, int cap, string citta, int superficie, int utentiInteressati, int superficieGiardino) : base(codice, indirizzo, cap, citta, superficie, utentiInteressati)
        {
            SuperficieGiardino = superficieGiardino;

        }
        public void AggiungiVilla(string codice, string indirizzo, int cap, string citta, int superficie, int utentiInteressati, int superficieGiardino)
        {
            Codice = codice;
            Indirizzo = indirizzo;
            Cap = cap;
            Citta = citta;
            Superficie = superficie;
            UtentiInteressati = utentiInteressati;
            SuperficieGiardino = superficieGiardino;

        }

        public void ReimpostaSuperficie(int nuovaSuperficie, int nuovaSuperficieGiardino)
        {
            Superficie = nuovaSuperficie;
            SuperficieGiardino = nuovaSuperficieGiardino;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nSuperficie giardino: {SuperficieGiardino}";
        }
    }
}
