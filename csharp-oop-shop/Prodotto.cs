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
    internal class Prodotto
    {
        private int _code;
        private string _name;
        private string _description;
        private double _price;
        private Iva _iva;

        public string getCode() => this._code.ToString().PadLeft(8, '0');
        public string Name { get { return this._name; } set { this._name = value; } }
        public string Description { get { return this._description; } set { this._description = value; } }
        public double Price { get { return this._price; } set { this._price = Math.Abs(value); } }
        public Iva Iva { get { return this._iva; } set { this._iva = value; } }

        public Prodotto(string name, string description, double price, Iva iva)
        {
            this._code = Random.Shared.Next(1, 100000000);
            // this.code = Random.Shared.Next(1, 10000); /* code formatter debugger */
            this._name = name;
            this._description = description;
            this._price = price;
            this._iva = iva;
        }

        public double getFullPrice() => this._price * (1 + (double)this._iva / 100);
        public string getExtendedName() => this._code.ToString() + " " + this._name;
    }

    public enum Iva
    {
        ORDINARIA = 22,
        RIDOTTA_4 = 4,
        RIDOTTA_5 = 5,
        RIDOTTA_10 = 10
    }
}
