using System;
namespace CsharpShop2
{
	public class EmptyBottleException : Exception
	{

		public EmptyBottleException() : base()
		{
		}

		public EmptyBottleException(string message) : base (message)
		{
		}

	}
}

