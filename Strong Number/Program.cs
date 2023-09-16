using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strong_Number
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			if (IsStrongNumber(number))
			{
				Console.WriteLine("yes");
			}
			else
			{
				Console.WriteLine("no");
			}
		}
		static bool IsStrongNumber(int number)
		{
			int originalNumber = number;
			int sumOfFactorials = 0;

			while (number > 0)
			{
				int digit = number % 10;
				sumOfFactorials += Factorial(digit);
				number /= 10;
			}

			return sumOfFactorials == originalNumber;
		}

		static int Factorial(int n)
		{
			if (n == 0 || n == 1)
				return 1;

			int result = 1;
			for (int i = 2; i <= n; i++)
			{
				result *= i;
			}

			return result;
		}
	}
}