/*
    creare la classe Prodotto che gestisce i prodotti dello shop.
    Un prodotto è caratterizzato da:
    - codice (numero intero)
    - nome
    - descrizione
    - prezzo
    - iva
    Usate opportunamente i livelli di accesso (public, private), i costruttori, 
    i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
    - alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
    - Il codice prodotto sia accessibile solo in lettura
    - Gli altri attributi siano accessibili sia in lettura che in scrittura
    - Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
    - Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
    - Testate poi i vostri oggetti Prodotto, istanziandoli e provando ad interargirci per testare tutti i metodi che avete previsto.
    BONUS:
    - create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri 
        (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)
    - Usando un array, dichiarate un elenco dei prodotti di un negozio e inseriteci al suo interno 
        qualche prodotto che vi aspettate di trovare nel negozio. Stampate poi l’elenco dei vostri 
        prodotti che avete previsto nel negozio.
 */
namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prodotto pane = new Prodotto("pane", "alimento contenente glutine", 0.5, Iva.RIDOTTA_4);
            Prodotto iPhone = new Prodotto("iPhone", "smartphone", 1000, Iva.ORDINARIA);
            Prodotto shampoo = new Prodotto("shampoo", "oggetto per la cura personale", 1.5, Iva.ORDINARIA);

            Console.WriteLine(Prettifier("get full name"));
            Console.WriteLine(pane.getExtendedName());
            Console.WriteLine(iPhone.getExtendedName());
            Console.WriteLine(shampoo.getExtendedName()+"\n");

            Console.WriteLine(Prettifier("get full price"));
            Console.WriteLine(pane.getFullPrice());
            Console.WriteLine(iPhone.getFullPrice());
            Console.WriteLine(shampoo.getFullPrice()+"\n");

            Console.WriteLine(Prettifier("code formatter"));
            Console.WriteLine(pane.getCode());
            Console.WriteLine(iPhone.getCode());
            Console.WriteLine(shampoo.getCode()+"\n");

            // BONUS
            Console.WriteLine(Prettifier("bonus"));
            Prodotto[] products = { pane, iPhone, shampoo };
            foreach (Prodotto product in products)
                Console.WriteLine(product.getExtendedName());
        }

        public static string Prettifier(string input) 
            => $"{String.Concat(Enumerable.Repeat("-", input.Length + 2))} \n {input.ToUpper()} \n{String.Concat(Enumerable.Repeat("-", input.Length + 2))}";
    }
}
