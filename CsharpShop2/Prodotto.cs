using System;
namespace CsharpShop2
{
	public class Prodotto
	{
		private int codice;
		private string nome;
		private string descrizione;
		private double prezzo;
		private int iva;

		public Prodotto(string nome, string descrizione, double prezzo, int iva)
		{
			this.nome = nome;
			this.descrizione = descrizione;
			this.prezzo = prezzo;
			this.iva = iva;

			codice = NumeroCasualeCodice();
		}

		public int GetCodice()
		{
			return codice;
		}

		public string GetNome()
		{
			return nome;
		}

		public string GetDescrizione()
		{
			return descrizione;
		}

		public double GetPrezzo()
		{
			return prezzo;
		}

		public int GetIva()
		{
			return iva;
		}


		public void StampaCalcoloPrezzoConIva()
		{
			double ivato = prezzo * iva;
			double prezzoFinale = prezzo + ivato / 100;
			Console.WriteLine("Prezzo finale: " + prezzoFinale + " € IVA: " + ivato / 100 + " €");
		}

		public double CalcoloPrezzoConIva()
		{
			double ivato = prezzo * iva;
			double prezzoFinale = prezzo + ivato / 100;
			return prezzoFinale;
		}

		public int NumeroCasualeCodice()
		{
			Random r = new Random();
			return r.Next(100000000);
		}
		public void StampaPrezzoSenzaIva()
		{
			Console.WriteLine("Prezzo prodotto senza Iva: " + prezzo + " €");
		}

		public void StampaPrezzoConIva()
		{
			Console.WriteLine("Prezzo prodotto con Iva: " + CalcoloPrezzoConIva() + " €");
		}

		public void StampaNomeCodice()
		{
			Console.WriteLine("Nome esteso prodotto " + NumeroCasualeCodice() + nome);
		}

		public virtual void StampaProdotto()
		{
			Console.WriteLine("---Prodotto---");
			Console.WriteLine("Prezzo senza IVA: " + prezzo + " €");
			Console.WriteLine("Prezzo con IVA: " + CalcoloPrezzoConIva() + " €");
			Console.WriteLine("Descrizione prodotto: " + descrizione);
			Console.WriteLine("Nome esteso prodotto " + codice + nome);
		}
	}
}

