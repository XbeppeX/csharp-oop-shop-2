using CsharpShop2;

Prodotto Mioprodotto = new Prodotto("banane", "Provenienza Africa", 3, 4);
Acqua bottiglia1 = new Acqua("Ferrarelle", "Minerale", 2.50, 4, 1, 7.5, "Roccamonfina");

int codice = Mioprodotto.GetCodice();
Console.WriteLine("Il codice prodotto è: " + codice);


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

