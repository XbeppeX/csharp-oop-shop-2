using CsharpShop2;

Prodotto Mioprodotto = new Prodotto("banane", "Provenienza Africa", 3, 4);
Acqua bottiglia1 = new Acqua("Ferrarelle", "Minerale", 2.50, 4, 1, 7.5, "Roccamonfina");
Elettrodomestico lavatrice = new Elettrodomestico("Lavatrice", "lavatrice 10kg", 200, 22, "Samsung");

lavatrice.StampaProdotto();

int codice = Mioprodotto.GetCodice();
Console.WriteLine("Il codice prodotto è: " + codice);
Console.WriteLine("Il codice prodotto è: " + Mioprodotto.GetDescrizione());

Console.WriteLine("Inserisci i litri da bere");
double litri = Convert.ToDouble(Console.ReadLine());

//try
try
{
    bottiglia1.Bevi(litri);
} catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Mi dispiace ma il parametro " + e.ParamName + " ha detto " + e.Message);
} catch (EmptyBottleException)
{
    Console.WriteLine("La tua bottiglia è vuota!");
}

Console.WriteLine("");

Mioprodotto.StampaProdotto();
Console.WriteLine("");

bottiglia1.StampaProdotto();
Console.WriteLine("");

bottiglia1.Bevi(0.5);
bottiglia1.StampaLitri();
bottiglia1.Svuota();
bottiglia1.Riempi(2);
bottiglia1.Svuota();

Console.WriteLine("");

Acqua.ConvertiInGalloni(10);

