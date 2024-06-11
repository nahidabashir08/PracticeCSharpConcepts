using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
	internal class OutRef
	{
		//Creating Method with Ref Parameters
		public  void MathRef(int number1, int number2, ref int Addition, ref int Subtraction)
		{
			Addition = number1 + number2;
			Subtraction = number1 - number2;
		}

		//Creating Method with out Parameters
		public  void MathOut(int number1, int number2, out int Addition, out int Subtraction)
		{
			Addition = number1 + number2;
			Subtraction = number1 - number2;
		}
	}
}
/*//Calling the Method with the REF arguments
int AdditionRef = 0;
int SubtractionRef = 0;
MathRef(200, 100, ref AdditionRef, ref SubtractionRef);
Console.WriteLine($"AdditionRef: {AdditionRef}");
Console.WriteLine($"SubtractionRef: {SubtractionRef}");

//Call the Method with the OUT arguments
int AdditionOut = 0;
int SubtractionOut = 0;
MathOut(200, 100, out AdditionOut, out SubtractionOut);
Console.WriteLine($"AdditionOut: {AdditionOut}");
Console.WriteLine($"SubtractionOut: {SubtractionOut}");*/