using System;
using System.Collections.Generic;
	public class stack
		{
		public static void Main()
		{
			Stack<int> stack = new Stack<int>();
		// 1. Push()
		stack.Push(10);
		stack.Push(20);
		stack.Push(30);
		stack.Push(40);
		Console.WriteLine("Stack:");
		PrintStack(stack);
			
		// 2. Pop()
		int poppedItem = stack.Pop();
		Console.WriteLine("\nPopped Item: {0}", poppedItem);
		Console.WriteLine("Stack after popping an item:");
		PrintStack(stack);
			
		// 3. Peek()
		int topItem = stack.Peek();
		Console.WriteLine("\nTop Item: {0}", topItem);
			
		// 4. Contains()
		int itemToFind = 30;
		bool containsItem = stack.Contains(itemToFind);
		Console.WriteLine("\nStack contains {0}?{1}",itemToFind,containsItem);
		itemToFind = 50;
		containsItem = stack.Contains(itemToFind);
		Console.WriteLine("Stack contains {0}? {1}",itemToFind, containsItem);
			
		// 5. Clear()
		stack.Clear();
		Console.WriteLine("Stack Clear");
		}
		public static void PrintStack(Stack<int> stack)
		{
		foreach (var item in stack)
		{
			Console.WriteLine(item);
		}
	}
}
