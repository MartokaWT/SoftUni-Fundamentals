using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			string action = Console.ReadLine();
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());

			if (action == "add")
			{
				Add(num1, num2);
			}
			else if (action == "subtract")
			{
				Subtract(num1, num2);
			}
			else if (action == "multiply")
			{
				Multiply(num1, num2);
			}
			else if (action == "divide")
			{
				Divide(num1, num2);
			}
		}

		private static void Add(int num1, int num2)
		{
			int result = num1 + num2;
			Console.WriteLine(result);
		}

		private static void Subtract(int num1, int num2)
		{
			int result = num1 - num2;
			Console.WriteLine(result);
		}

		private static void Multiply(int num1, int num2)
		{
			int result = num1 * num2;
			Console.WriteLine(result);
		}

		private static void Divide(int num1, int num2)
		{
			int result = num1 / num2;
            Console.WriteLine(result);
        }
	}
}