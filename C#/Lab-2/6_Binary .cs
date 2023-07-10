using System;


namespace Lab_2
{
    public class Binary 
    {
      public  static void Main(string[] args)
        {
            Console.WriteLine("Enter Integer Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Binary : " + (Convert.ToString(num1, 2)));
        }
    }
}