using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Fibonacci
{
	internal class Program
	{
		static void Main()
		{
			int n = int.Parse(Console.ReadLine());

			long fibonacciNumber = GetFibonacci(n);

			Console.WriteLine(fibonacciNumber);
		}

		static long GetFibonacci(int n)
		{
			if (n == 1 || n == 2)
			{
				return 1;
			}

			return GetFibonacci(n - 1) + GetFibonacci(n - 2);
		}
	}
}