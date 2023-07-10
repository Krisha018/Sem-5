using System;


namespace Lab_1_3
{
    public class Fahrenheit_Celsius
    {
        public static void Main(string[] args)
    {
			int f,c;
           Console.Write("Enter Farenheit : ");
             f = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter  Celsius : ");
             c = Convert.ToInt32(Console.ReadLine());

            int fer = (9 / 5) * c + 32;
            int cel = (f - 32) * 5 / 9;

            Console.WriteLine("F to C : " + cel);
            Console.WriteLine("C to F : " + fer);

        
        
    }
}
}