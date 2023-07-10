using System;
	
public class Candidate
{
	int C_ID;
	string C_Name;
	int C_Age;
	int C_Weight;
	int C_height;
	
	public void getDetails()
	{
		Console.WriteLine("Enter a ID :");
		this.C_ID=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter a Name :");
		this.C_Name=(Console.ReadLine());
		Console.WriteLine("Enter a Age :");
		this.C_Age=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter a Weight :");
		this.C_Weight=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter a Height :");
		this.C_height=int.Parse(Console.ReadLine());
		
	}
	public void displayDetails()
	{
		Console.WriteLine("ID :"+C_ID);
		Console.WriteLine("Name :"+C_Name);
		Console.WriteLine("Age :"+C_Age);
		Console.WriteLine("Weight :"+C_Weight);
		Console.WriteLine("Height :"+C_height);
	}
	
}

public class Program
{
	public static void Main()
	{
		Candidate obj=new Candidate();
		obj.getDetails();
		obj.displayDetails();
	}
}
