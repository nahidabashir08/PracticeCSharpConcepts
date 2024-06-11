using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
	public static class ExtensionMethod
	{
		public static int GetWordCount(this string stringInput)
		{
			if(!string.IsNullOrEmpty(stringInput))
			{
				string[] words = stringInput.Split(" ");
				return words.Count();

			}
			else
			{
				return 0;
			}
		}
	}
}

/*string myWord = "Nahida Bashir";
int myWordCount = myWord.GetWordCount();
Console.WriteLine(myWordCount);
Console.WriteLine(myWord);*/