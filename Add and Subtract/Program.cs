using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_and_Subtract
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());
			int num3 = int.Parse(Console.ReadLine());

			int sumResult = Sum(num1, num2);
			int finalResult = Subtract(sumResult, num3);

			Console.WriteLine(finalResult);
		}

		public static int Sum(int a, int b)
		{
			return a + b;
		}

		public static int Subtract(int result, int c)
		{
			return result - c;
		}
	}
}