using System;


namespace Lab_1_3
{
    public class Program
    {
        public static void Main(string[] args)
    {
        string Name;
        string Country;
        Console.WriteLine("Enter a Name :");
        Name = (Console.ReadLine());

        Console.WriteLine("Enter a Country  :");
        Country = (Console.ReadLine());
        Console.WriteLine("Hello " + Name + "  from Country " + Country);
        
    }
}
}