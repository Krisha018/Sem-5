using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Program
    {
      public  static void Main(string[] args)
        {
			  int num1,num2,num3;
            Result r = new Result();
           Console.WriteLine("Enter First Number : ");
             num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
             num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Addition Of " + num1 + " and " + num2 + " is " + r.addition(num1, num2));
            Console.WriteLine("Subtraction Of " + num1 + " and " + num2 + " is " + r.subtraction(num1, num2));

        }
    }

    interface Calculate
    {
        int addition(int a, int b);
        int subtraction(int a, int b);
    }

  public  class Result : Calculate
    {
        public int addition(int a, int b)
        {
            return a + b;
        }

        public int subtraction(int a, int b)
        {
            return a - b;
        }
    }
}