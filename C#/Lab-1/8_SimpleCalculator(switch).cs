using System;

namespace Lab_1_8
{
   public class SimpleCalculator
    {
    public  static void Main(string[] args)
        {
           int num1,num2,ans,ch;
           Console.WriteLine("Enter First Number : ");
            num1 =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            num2 = int.Parse(Console.ReadLine());
		
            Console.WriteLine("Enter Choice : ");
             ch =  int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
					
        			ans =  num1 + num2;
                    Console.WriteLine(ans);
                    break;

                case 2:
                  
        			ans =  num1 - num2;
                    Console.WriteLine("ans :"+ans);
                    break;

                case 3:
                  
        			ans =  num1 * num2;
                    Console.WriteLine("ans :"+ans);
                    break;

                case 4:
                  
        			ans =  num1 / num2;
                    Console.WriteLine("ans :"+ans);
                    break;

                case 5:
                  
        			ans =  num1 % num2;
                   Console.WriteLine("ans :"+ans);
                    break;
            }
        }
    }
}
        
   