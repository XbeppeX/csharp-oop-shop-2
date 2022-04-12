using System;
namespace CsharpShop2
{
	public class Acqua : Prodotto
	{
		private double litri;

		public Acqua(string nome, string descrizione, double prezzo, int iva, double litri) : base(nome, descrizione, prezzo, iva)
		{
			this.litri = litri;
			DimensioneBottiglia();
		}

		public void DimensioneBottiglia()
        {
			if (litri <= 1.5)
            {
				Console.WriteLine("Bottiglia di litri: " + litri + "Ammessa");
            } else
            {
				Console.WriteLine("Impossibile vendere bottiglie d'acqua superiori al 1.5lt! ");
			}
        }

		public override void StampaProdotto()
		{
			if (litri <= 1.5)
			{
				base.StampaProdotto();
				Console.WriteLine("Litri: " + litri);
			} else
			{
				Console.WriteLine("Impossibile Stampare Prodotto");
			}
		}
	}
}

