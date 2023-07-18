using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Program
    {
       public static void Main(string[] args)
        {
		   int num1,num2,num3;
            Result r = new Result();
            Console.WriteLine("Enter First Number : ");
             num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
             num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum Of " + num1 + " and " + num2 + " is " + r.sumOfTwo(num1, num2));
            Console.WriteLine("Enter Third Number : ");
             num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum Of " + num1 + "," + num2 + " and " + num3 + " is " + r.sumOfThree(num1, num2, num3));

        }
    }

   public  abstract class SumOfAbstract
    {
        public abstract int sumOfTwo(int a, int b);
        public abstract int sumOfThree(int a, int b, int c);
    }

    public class Result : SumOfAbstract
    {
        public override int sumOfTwo(int a, int b)
        {
            return a + b;
        }

        public override int sumOfThree(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}