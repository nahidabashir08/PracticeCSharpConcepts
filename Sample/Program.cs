using System;
using Sample;
using ThrowAndTrowEx;
using LinqPractice;
using ExtensionMethod;

namespace RefvsOutDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			LinqPractic linqPractice = new LinqPractic();
			linqPractice.LinqPrcatice();
			linqPractice.MethodLinq();

			OutRef outRef=new OutRef();
			int AdditionRef = 0;
			int SubtractionRef = 0;
			outRef.MathRef(200, 100, ref AdditionRef, ref SubtractionRef);
			Console.WriteLine($"AdditionRef: {AdditionRef}");
			Console.WriteLine($"SubtractionRef: {SubtractionRef}");

			//Call the Method with the OUT arguments
			int AdditionOut = 0;
			int SubtractionOut = 0;
			outRef.MathOut(200, 100, out AdditionOut, out SubtractionOut);
			Console.WriteLine($"AdditionOut: {AdditionOut}");
			Console.WriteLine($"SubtractionOut: {SubtractionOut}");
			Console.ReadKey();
		}

		
	}
}