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
    
    


