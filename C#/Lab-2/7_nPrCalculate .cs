using System;


namespace Lab_2
{
    public class nPrCalculate 
    {
    public  static void Main(string[] args)
        {
		int n,r;
            Console.WriteLine("Enter N : ");
             n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter R : ");
             r =  int.Parse(Console.ReadLine());
            Console.WriteLine(n + "P" + r + " = "+ nPr(n, r));
        }

        static int fact(int n)
        {
            if (n <= 1)
                return 1;
            return n * fact(n - 1);
        }

        static int nPr(int n, int r)
        {
            return fact(n) / fact(n - r);
        }
    }
}