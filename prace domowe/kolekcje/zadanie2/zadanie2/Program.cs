using System;

namespace zadanie2
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = new int[10] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
			for (int i = 0; i < numbers.Length; i++)
			{
				Console.WriteLine("Liczba: " + numbers[i]);
			}
			foreach (int number in numbers)
			{
				Console.WriteLine("Liczba: " + number);
			}
			int j = 0;
			while (j < numbers.Length)
			{
				Console.WriteLine("Liczba: " + numbers[j]);
				j++;
			}
		}
	}
}
