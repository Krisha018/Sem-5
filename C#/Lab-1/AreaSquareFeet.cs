using System;


namespace Lab_1_3
{
    public class AreaSquareFeet
    {
        public static void Main(string[] args)
    {
            double length;
            double width;
        Console.WriteLine("Enter a length :");
        length = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter a width  :");
         width = double.Parse(Console.ReadLine());

        Console.WriteLine("Size of Area : " + (length*width));
        
    }
}
}