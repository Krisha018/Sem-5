

using System;

namespace SimpleInterest
{
   public class Program
    {
    public  static void Main(string[] args)
        {
           
            double p,r,n,si;
            
            //take input of principal, interest rate and time
            Console.Write("Enter P : ");
            p = double.Parse(Console.ReadLine());
            Console.Write("Enter R : ");
            r = double.Parse(Console.ReadLine());
            Console.Write("Enter N :");
            n = double.Parse(Console.ReadLine());
            
            
            si=p*r*n/100;
            
           
            Console.Write("Simple interest :"+si);
            
           
        }
    }
}
        
   