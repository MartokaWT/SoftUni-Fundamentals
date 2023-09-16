using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facorial_Division
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());

			decimal factorial1 = CalculateFactorial(num1);
			decimal factorial2 = CalculateFactorial(num2);

			decimal result = factorial1 / factorial2;

			Console.WriteLine($"{result:F2}");
		}
		public static decimal CalculateFactorial(int n)
		{
			decimal factorial = 1;

			for (int i = 1; i <= n; i++)
			{
				factorial *= i;
			}

			return factorial;
		}
	}
}