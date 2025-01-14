namespace agenziaImmobiliare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var box = new Box(codice: "b001", indirizzo: "Via Puglia 2", cap: 12345, citta: "Firenze", superficie: 100, postiAuto: 2, utentiInteressati:4);
            var abitazione = new Abitazione(codice: "a001", indirizzo: "Via Damiani 4", cap: 12345, citta: "San Benedetto del Tronto", superficie: 100, numeroVani: 2, numeroBagni: 3, utentiInteressati:3);
            var villa = new Villa(codice: "v001", indirizzo: "Via Campania 2", cap: 12345, citta: "Napoli", superficie: 100, superficieGiardino: 20, utentiInteressati:1);
            
            var box1 = new Box("b001", "Via Puglia 2", 12345, "Firenze", 100, 2, 4);
            var abitazione1 = new Abitazione("a001", "Via Damiani 4", 12345, "San Benedetto del Tronto", 100, 2, 3, 3);
            var villa1 = new Villa("v001", "Via Campania 2", 12345, "Napoli", 100, 20, 1);

           
            box.AggiungiBox(box1.Codice, box1.Indirizzo, box1.Cap, box1.Citta, box1.Superficie, box1.UtentiInteressati, box1.PostiAuto);
            abitazione.AggiungiAbitazione(abitazione1.Codice, abitazione1.Indirizzo, abitazione1.Cap, abitazione1.Citta, abitazione1.Superficie, abitazione1.UtentiInteressati, abitazione1.NumeroVani, abitazione1.NumeroBagni);
            villa.AggiungiVilla(villa1.Codice, villa1.Indirizzo, villa1.Cap, villa1.Citta, villa1.Superficie, villa1.UtentiInteressati, villa1.SuperficieGiardino);


        }
    }
}
