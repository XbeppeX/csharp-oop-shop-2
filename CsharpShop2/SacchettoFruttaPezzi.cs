using System;
namespace CsharpShop2
{
	public class SacchettoFruttaPezzi : Prodotto
	{
		private int pezzi;
		public static readonly int massimiPezziSacchetto = 5;

		public SacchettoFruttaPezzi(string nome, string descrizione, double prezzo, int iva, int pezzi) : base(nome, descrizione, prezzo, iva)
		{
			this.pezzi = pezzi;
			CalcoloPezziSacchetto();
		}

		public int GetPezzi()
		{
			return pezzi;
		}

		public void CalcoloPezziSacchetto()
		{
			if (pezzi <= massimiPezziSacchetto)
			{
				Console.WriteLine("Pezzi nel sacchetto: " + pezzi + " Ammessa");
			}
			else
			{
				Console.WriteLine("Impossibile vendere sacchetto di frutta");
			}
		}

		public override void StampaProdotto()
		{
			if (pezzi <= massimiPezziSacchetto)
			{
				base.StampaProdotto();
				Console.WriteLine("Pezzi sacchetto: " + pezzi);
				
			}
			else
			{
				Console.WriteLine("Impossibile Stampare Prodotto");
			}
		}
	}
}

