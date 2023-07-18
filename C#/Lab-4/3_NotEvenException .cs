using System;
namespace ExceptionHandlingExample
{
	public class NotEvenException : Exception
	{
		public NotEvenException(string msg) : base(msg)
		{
		}
	}
	public class Program
	{
		public static void Main(string[] args)
		{
			int num;
			try
			{
				Console.Write("Enter a number: ");
				num = Convert.ToInt32(Console.ReadLine());
				if ((num % 2) != 0)
				{
				throw new NotEvenException("Not an even number ");
				}
				else
				{
				Console.WriteLine("Its even number ");
				}
			}
			catch (NotEvenException e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}