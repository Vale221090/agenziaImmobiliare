using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenziaImmobiliare
{
    public class Immobili
    {
        public string Codice { get; set; }
        public string Indirizzo { get; set; }
        public int Cap { get; set; }
        public string Citta { get; set; }
        public int Superficie { get; set; }

        public int UtentiInteressati { get; set; }
        public Immobili(string codice, string indirizzo, int cap, string citta, int superficie, int utentiInteressati=0)
        {
            Codice = codice;
            Indirizzo = indirizzo;
            Cap = cap;
            Citta = citta;
            Superficie = superficie;
            UtentiInteressati = utentiInteressati;
        }
        public void AggiungiImmobile(string codice, string indirizzo, int cap, string citta, int superficie)
        {
            Codice = codice;
            Indirizzo = indirizzo;
            Cap = cap;
            Citta = citta;
            Superficie = superficie;
        }

        public void AumentoInteressati(int aumentoInteressati)
        {
            UtentiInteressati += aumentoInteressati;
        }
        public void DiminuzioneInteressati(int diminuzioneInteressati)
        {
            UtentiInteressati -= diminuzioneInteressati;
        }
        public void StampaInfoImmobile()
        {
            Console.WriteLine($"Codice: {Codice}\nIndirizzo: {Indirizzo}\nCap: {Cap}\nCitta: {Citta}\nSuperficie: {Superficie}\nUtenti interessati: {UtentiInteressati}");
        }
        public override string ToString()
        {
            return $"{Indirizzo}\n {Cap} {Citta} \nmq {Superficie}";
        }
        public void ReimpostaSuperficie(int nuovaSuperficie)
        {
            Superficie = nuovaSuperficie;
        }

    }

    
    

   
   
}
    
    


