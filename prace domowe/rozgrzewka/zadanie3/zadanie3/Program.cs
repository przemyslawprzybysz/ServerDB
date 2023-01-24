using System;

namespace zadanie3
{
	class Program
	{
		static void Main(string[] args)
		{
			int result = 5 + 9;
			//brak średnika powodował błąd, dodatkowo warning, że zadeklarowana zmienna nie jest używana
			Console.WriteLine(result);
		}
	}
}
