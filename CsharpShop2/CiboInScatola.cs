using System;
namespace CsharpShop2
{
	public class CiboInScatola : Prodotto
	{
		public static readonly int massimoPesoScatola = 300;

		public CiboInScatola(string nome, string descrizione, double prezzo, int iva) : base(nome, descrizione, prezzo, iva)
		{

		}

		public int GetMassimoPesoScatola()
		{
			return massimoPesoScatola;
		}

		public override void StampaProdotto()
		{
			base.StampaProdotto();
			Console.WriteLine("Massimo peso per scatola : " + massimoPesoScatola);
		}
	}
}

