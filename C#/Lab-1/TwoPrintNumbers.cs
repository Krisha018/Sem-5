using System;
namespace Lab_1_2
{
    public class TwoPrintNumbers
    {
        public static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Enter First Number :");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number :");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("First Number : "+n1);
            Console.WriteLine("Second Number : " + n2);
        }
    }
}