using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThrowAndTrowEx;

namespace ThrowAndTrowEx
{
	public class ThrowAndThrowEx{
		public static void Fun1()
		{
			try
			{
				Fun2();
			}
			catch (Exception)
			{

				throw;
			}
		}

		public static void Fun2() {
			try
			{
				throw new Exception("Fun2 Exception");

			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public static void fun3()
		{
			try
			{
				Fun2();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
	}

}


/*try
{
	//ThrowAndTrowEx.ThrowAndThrowEx.Fun1();
	ThrowAndThrowEx.fun3();
}
catch (Exception ex)
{

	Console.WriteLine(ex.StackTrace);
}*/