using System;

namespace Lab_1_8
{
   public class Max_3_Numbers
    {
    public  static void Main(string[] args)
        {
		int num1,num2,num3;
            Console.WriteLine("Enter Number : ");
             num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number : ");
             num2 =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number : ");
		
             num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1 + " Is Greater");
            }
            else if (num2 > num3)
            {
                Console.WriteLine(num2 + " Is Greater");
            }
            else
            {
                Console.WriteLine(num3 + " Is Greater");
            }
        }
    }
}
        
   