using System;


namespace Lab_1_3
{
    public class Area
    {
        public static void Main(string[] args)
    {
            int l,b,h,r;
            
        Console.WriteLine("Enter a length :");
        l = int.Parse(Console.ReadLine());
		Console.WriteLine("Square Area : " + (l * l));

        Console.WriteLine("Enter a Radius  :");
         r = int.Parse(Console.ReadLine());
		 Console.WriteLine("Circle Area : " + (Math.PI * r * r));
			
		Console.WriteLine("Enter a Breath  :");
         b = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter a Height  :");
         h = int.Parse(Console.ReadLine());
		 Console.WriteLine("Tringle Area : " + (0.5 * h * b));
			
		Console.WriteLine("Enter a length  :");
         l = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter a Breath  :");
         b = int.Parse(Console.ReadLine());
	 Console.WriteLine("Rectangle Area : " + (l*b));


        
        
    }
}
}