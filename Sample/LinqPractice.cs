using LinqPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
	internal class LinqPractic
	{
		public void  LinqPrcatice() {
			List<int> list = new List<int> { 1,2,3,4,5,6,7,8,9,10};

			var queryList = from obj in list
							where obj%2 == 0
							select obj;

			foreach(var item in queryList )
			{
				Console.WriteLine(item+" ");
			}
		}
		public void MethodLinq() {
			List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			var methodLinq = list.Where(x => x % 2 != 0).ToList();
			foreach( var item in methodLinq )
			{
				Console.WriteLine(item+" ");
			}
		}
	}
}

/*LinqPractic linqPractice = new LinqPractic();
linqPractice.LinqPrcatice();
linqPractice.MethodLinq();*/