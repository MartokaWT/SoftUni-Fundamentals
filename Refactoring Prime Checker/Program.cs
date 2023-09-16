using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Prime_Checker
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int upperLimit = int.Parse(Console.ReadLine());

			for (int number = 2; number <= upperLimit; number++)
			{
				bool isPrime = true;

				for (int divisor = 2; divisor < number; divisor++)
				{
					if (number % divisor == 0)
					{
						isPrime = false;
						break;
					}
				}

				Console.WriteLine("{0} -> {1}", number, isPrime);
			}
		}
	}
}