using System;
namespace CsharpShop2
{
	public class Elettrodomestico : Prodotto
	{
		private string marca;
		private bool stato;

		public Elettrodomestico(string nome, string descrizione, double prezzo, int iva, string marca) : base(nome, descrizione, prezzo, iva)
		{
			this.marca = marca;
			this.stato = false;
			
		}

		public string GetMarca()
        {
			return marca;
        }

		public bool GetStato()
		{
			return stato;
		}

		public void Spegni()
        {
			Console.WriteLine("Il tuo elettrodomestico è spento");
			stato = false;
        }

		public void Accendi()
		{
			Console.WriteLine("Il tuo elettrodomestico è acceso");
			stato = true;
		}

		public bool CheckStato()
        {
			if (stato == false)
			{
				Console.Write("spento");
				stato = false;
			}
			else
			{
				Console.Write("Acceso");
				stato = true;
			}

			return stato;
		}

		public override void StampaProdotto()
		{
			base.StampaProdotto();
			Console.WriteLine("Marca: " + marca);
			Console.WriteLine("Stato " + CheckStato());
		}
	}
}

