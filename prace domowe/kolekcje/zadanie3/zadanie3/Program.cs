using System;
using System.Collections.Generic;

namespace zadanie3
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> fruits = new List<string>();
			fruits.Add("jablko");
			fruits.Add("gruszka");
			fruits.Add("cytryna");
			fruits.Add("agrest");
			Console.WriteLine(fruits[0]+", "+ fruits[1] + ", "+ fruits[2] + ", "+ fruits[3]);
			fruits.Remove("jablko");
			fruits.RemoveAt(2);
			Console.WriteLine(fruits[0] + ", " + fruits[1]);
		}
	}
}
