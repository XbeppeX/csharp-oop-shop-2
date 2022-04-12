using CsharpShop2;

Prodotto Mioprodotto = new Prodotto("banane", "Provenienza Africa", 3, 4);
Acqua bottiglia1 = new Acqua("Ferrarelle", "Minerale", 2.50, 4, 3);

int codice = Mioprodotto.GetCodice();
Console.WriteLine("Il codice prodotto è: " + codice);


Mioprodotto.StampaCalcoloPrezzoConIva();

Mioprodotto.StampaPrezzoConIva();

Mioprodotto.StampaPrezzoSenzaIva();

Console.WriteLine("");

Mioprodotto.StampaProdotto();

Console.WriteLine("");

bottiglia1.StampaProdotto();

