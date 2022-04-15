using System;
namespace CsharpShop2
{
	public class CiboInScatola : Prodotto
	{
		private int peso;
		public static readonly int massimoPesoScatola = 300;

		public CiboInScatola(string nome, string descrizione, double prezzo, int iva,int peso) : base(nome, descrizione, prezzo, iva)
		{
			this.peso = peso;
		}

		public int GetMassimoPesoScatola()
		{
			return massimoPesoScatola;
		}

		public void CheckPeso()
        {
			if (peso <= massimoPesoScatola)
			{
				Console.WriteLine("Peso cibo in scatola: " + peso + " Ammessa");
			}
			else
			{
				Console.WriteLine("Impossibile vendere cibo in scatola superiore a: " + massimoPesoScatola + " g di peso");
			}
		}

		public override void StampaProdotto()
		{
			if (peso <= massimoPesoScatola)
			{
				base.StampaProdotto();
				Console.WriteLine("Massimo peso per scatola : " + massimoPesoScatola);
			}
			else
			{
				Console.WriteLine("Impossibile Stampare Prodotto");
			}
			
		}
	}
}

