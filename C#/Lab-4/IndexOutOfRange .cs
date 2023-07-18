using System;

	public class IndexOutOfRange 
	{
		public static void Main()
		{
			try
			{
				int[] arr = new int[5];
				for (int i = 0; i < 5; i++)
				{
					Console.Write("Enter no {0}: ", (i + 1));
					arr[i] = Convert.ToInt32(Console.ReadLine());
				}
				for (int i = 0; i <= 5; i++)
				{
					Console.WriteLine("{0} ", arr[i]);
				}
			}
			catch (IndexOutOfRangeException e)
			{
				Console.Write(e.Message);
			}
	}
}
