using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class ChangeCase
    {
       public static void Main(string[] args)
        {
           string str1;
		char[] arr1;
		int l, i;
		l = 0;
		char ch;
		Console.Write("Enter the string : ");
		str1 = Console.ReadLine();
		l = str1.Length;
		arr1 = str1.ToCharArray(0, l);
		Console.Write("\nAfter conversion, the string is : ");
		for (i = 0; i < l; i++)
		{
			ch = arr1[i];
		if (Char.IsLower(ch))
		{
		Console.Write(Char.ToUpper(ch));
		}
		else
		{
		Console.Write(Char.ToLower(ch));
		}
        }
    	}
	}
}