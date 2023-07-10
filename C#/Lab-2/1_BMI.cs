using System;

namespace Lab_1_8
{
   public class BMI
    {
    public  static void Main(string[] args)
        {
		double pound;
		double inches;
		double w;
		double h;
		  Console.WriteLine("Enter Weight in Pound : ");
             pound = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height in inches : ");
             inches = double.Parse(Console.ReadLine());
		
             w = pound * 0.45359237;
             h = inches * 0.0254;
            Console.WriteLine("Body Index Mass : " + (w / (h * h)));
        }
    }
}
        
   
