using System;
using System.Collections.Generic;
using DelegatesList;

class Program
{
	static void Main()
	{
		Calculator objCal = new Calculator();

		// Create list of delegates
		Console.WriteLine("enter first numver");
		int a=Int32.Parse(Console.ReadLine());
		Console.WriteLine("enter second numver");
		int b=Int32.Parse(Console.ReadLine());



		List<delCal> delList = new List<delCal>();

		Console.WriteLine("1 to add");
		Console.WriteLine("2 to sub");
		Console.WriteLine("3 to mul");
        Console.WriteLine("enter your choice ");
		int choice=Int32.Parse(Console.ReadLine());


		if (choice == 1)
		{
			delList.Add(objCal.add);
		}
		else if (choice == 2)
		{

			delList.Add(objCal.sub);
		}
		else if (choice == 3)
		{

			delList.Add(objCal.mul);
		}
		delCal res = (delCal)Delegate.Combine(delList.ToArray()); //creating invoacation list
		res(a, b);
		//use res+=c.mult;
		//res+=c.add   when methods are invoked is a serial manner othr wise use list or ARRAY

	}
}