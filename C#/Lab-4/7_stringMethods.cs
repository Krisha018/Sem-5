using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class StringMethods
    {
       public static void Main(string[] args)
        {
            String s = "Krisha Padaliya";

            Console.WriteLine("Length Of Stinrg Is : " + s.Length);
            Console.WriteLine("Substring : " + s.Substring(1));
            Console.WriteLine("Contains: " + s.Contains("Krisha"));
		   Console.WriteLine("firstname.StartsWith:"+s.StartsWith("K"));
            Console.WriteLine("Replaced : " + s.Replace("Krisha", "krisha"));
            Console.WriteLine("Index of 'Yash': " + s.IndexOf("Krisha"));
            Console.WriteLine("Upper Case Conversion: " + s.ToUpper());
            Console.WriteLine("Lower Case Conversion: " + s.ToLower());
            Console.WriteLine("Formate String : " + string.Format("Hello ! I'm {0}", s));
        }
    }
}