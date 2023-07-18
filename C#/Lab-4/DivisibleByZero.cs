using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
 public   class Program
    {
    public   static void Main(string[] args)
        {
            int n1, n2;
            double ans;
            
                Console.WriteLine("Enter n1 : ");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter n2 : ");
                n2= int.Parse(Console.ReadLine());

                try
                {
                    ans = n1 / n2;
                    Console.WriteLine("Ans : " + ans);
                }

            
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divisible by Zero");
            }




        }
    }
}
