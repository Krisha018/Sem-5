using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Account_Details
    {
        public int AccountNumber;
        public String UserName;
        public String Email;
        public String Type;
        public double Balance;

        public Account_Details()
        {
            Console.WriteLine("Enter Account Number : ");
            this.AccountNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter User Name : ");
            this.UserName = Console.ReadLine();
            Console.WriteLine("Enter Email : ");
            this.Email = Console.ReadLine();
            Console.WriteLine("Enter Type : ");
            this.Type = Console.ReadLine();
            Console.WriteLine("Enter Balance : ");
            this.Balance = Convert.ToDouble(Console.ReadLine());
        }

    }
  public  class Calculate : Account_Details
    {
        public double TimePeriod;
        public double RateOfIntrest;

        public Calculate()
            : base()
        {
            Console.WriteLine("Enter Time Period : ");
            this.TimePeriod = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Rate Of Intrest : ");
            this.RateOfIntrest = Convert.ToDouble(Console.ReadLine());
        }

        public void calculateROI()
        {
            Console.WriteLine("ROI : " + (Balance * RateOfIntrest * TimePeriod) / 100);
        }
    }

  public  class Demo
    {
     public   static void Main(string[] args)
        {
            Calculate c = new Calculate();
            c.calculateROI();


        }
    }
}