using System;

namespace zadanie3
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 10;
			for (int i = 0; i <= n; i++)
			{
				if (i % 2 == 0)
				{
					Console.WriteLine(i + " - Parzysta");
				}
				else
				{
					Console.WriteLine(i +" - Nieparzysta");
				}
			}
			
		}
	}
}
