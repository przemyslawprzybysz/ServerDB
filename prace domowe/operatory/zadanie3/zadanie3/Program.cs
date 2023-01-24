using System;

namespace zadanie3
{
	class Program
	{
		static void Main(string[] args)
		{
			bool isTrue = true;
			bool isFalse = false;
			bool isReallyTrue = true;
			bool and = isTrue && isFalse;
			bool or = isTrue || isReallyTrue;
			bool negative = !isFalse;
			Console.WriteLine(and);
			Console.WriteLine(or);
			Console.WriteLine(negative);
		}
	}
}
