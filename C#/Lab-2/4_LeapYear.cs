using System;

public class LeapYear
{
    public static void Main(string[] args)
    {
        int n;
          Console.Write("Enter Year : ");
            n =int.Parse(Console.ReadLine());
            if (n % 400 == 0)
            {
                Console.WriteLine("Leap Year");
            }
            else if (n % 100 == 0)
            {
                Console.WriteLine("Not Leap Year");
            }
            else if (n % 4 == 0)
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not Leap Year");
            }


    }
}
