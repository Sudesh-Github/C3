using System;
using System.Collections.Generic;
using System.Linq;

class Employee5c
{
	static public void Main()
	{
       LinkedList<String> my_list = new LinkedList<String>();

		my_list.AddFirst("Abdul 1001");
		my_list.AddFirst("Shilpa 1002");
		my_list.AddFirst("Raju 1003");
		my_list.AddFirst("Jack 1004");
		my_list.AddFirst("Sam 1005");
		my_list.AddFirst("Akhtar 1006");

		foreach (string str in my_list)
		{
			Console.WriteLine(str);
		}
		Console.WriteLine("Present Employess"   + "              ");


		my_list.AddFirst("Kannan 1009");

		foreach (string str in my_list)
		{
			Console.WriteLine(str);
		}

		Console.WriteLine("Updated Employees List");

		{
			Console.WriteLine("Count of nodes is " + my_list.Count());
		}
		Console.ReadKey();
	}
}
	