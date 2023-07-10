
using System;

namespace Lab_1_8
{
   public class SimpleCalculator
    {
    public  static void Main(string[] args)
        {
           int num1,num2;
            Console.WriteLine("Enter First Number : ");
             num1 = int.Parse(Console.ReadLine());
		
            Console.WriteLine("Enter Second Number : ");
             num2 = int.Parse(Console.ReadLine());
		
            Console.WriteLine("Enter Choice : ");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == '+')
            {
                Console.WriteLine("Addition : " + (num1 + num2));
            }
            else if (ch == '-')
            {
                Console.WriteLine("Subtraction : " + (num1 - num2));
            }
            else if (ch == '*')
            {
                Console.WriteLine("Multiplication : " + (num1 * num2));
            }
            else if (ch == '/')
            {
                Console.WriteLine("Division : " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("Modulo : " + (num1 % num2));
            }
        }
    }
}
        
   