using System;
namespace CsharpShop2
{
	public class Acqua : Prodotto
	{
		private double litri;
		private readonly double ph;
		private string sorgente;
		public static readonly double massimaDimensioneBottiglia = 1.5;
		public static readonly double gallone = 3.785;


		public Acqua(string nome, string descrizione, double prezzo, int iva, double litri, double ph, string sorgente) : base(nome, descrizione, prezzo, iva)
		{
			this.litri = litri;
			this.ph = ph;
			this.sorgente = sorgente;
			CalcoloDimensioneBottiglia();
		}

		public string GetSorgente()
		{
			return sorgente;
		}

		public double GetPh()
		{
			return ph;
		}

		public double GetLitri()
		{
			return litri;
		}

		public void Svuota()
        {
			if (this.litri > 0 && this.litri <= massimaDimensioneBottiglia)
			{				
				Console.WriteLine("Hai svuotato la tua bottiglia di acqua" );
				this.litri = 0;
			}
			else
			{
				Console.WriteLine("Bottiglia già vuota, non puoi svuotare ancora");
			}
		}

		public void Riempi(double litriDaRiempire)
		{
			if (this.litri + litriDaRiempire <= massimaDimensioneBottiglia)
			{
				this.litri = this.litri + litriDaRiempire;
				Console.WriteLine("Hai riempito la tua bottiglia di" + litriDaRiempire);
			}
			else
			{
				Console.WriteLine("Bottiglia piena, non puoi riempire di più.");
				this.litri = massimaDimensioneBottiglia;
			}
		}

		public void Bevi(double litriDaBere)
        {
            if (litriDaBere < 0)
            {
				throw new ArgumentOutOfRangeException("litriDabere, ", "Il suo valore è negativo");
            }

			if(this.litri - litriDaBere > 0)
            {
				this.litri = this.litri - litriDaBere;
				Console.WriteLine("glu glu glu, ho bevuto " + litriDaBere);
			} else
			{
				throw new EmptyBottleException();
				this.litri = 0;
			}
		}

		public void CalcoloDimensioneBottiglia()
        {
			if (litri <= massimaDimensioneBottiglia)
            {
				Console.WriteLine("Bottiglia di litri: " + litri + " Ammessa");
            } else
            {
				Console.WriteLine("Impossibile vendere bottiglie d'acqua superiori al 1.5lt! ");
			}
        }

		public void StampaLitri()
        {
			Console.WriteLine("I litri della bottiglia sono: " + litri);
		}

		public static void ConvertiInGalloni(double litriDaConvertire)
        {
			decimal litroConvertito = Convert.ToDecimal(litriDaConvertire / gallone);
			litroConvertito = Math.Truncate(litroConvertito * 1000m) / 1000m;
			Console.WriteLine("--Conversione--");
			Console.WriteLine(litriDaConvertire + "litri = " + litroConvertito + " gallone");
		}

		public override void StampaProdotto()
		{
			if (litri <= massimaDimensioneBottiglia)
			{
				base.StampaProdotto();
				Console.WriteLine("Litri: " + litri);
				Console.WriteLine("Ph: " + ph);
				Console.WriteLine("Sorgente: " + sorgente);
			} else
			{
				Console.WriteLine("Impossibile Stampare Prodotto");
			}
		}
	}
}

