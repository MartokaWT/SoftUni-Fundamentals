using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operations
{
	internal class Program
	{
		static void Main()
		{
			double number1 = double.Parse(Console.ReadLine());
			string op = Console.ReadLine();
			double number2 = double.Parse(Console.ReadLine());

			double result = Calculate(number1, op, number2);

			Console.WriteLine(result);
		}

		static double Calculate(double num1, string op, double num2)
		{
			double result = 0;

			switch (op)
			{
				case "/":
					result = num1 / num2;
					break;
				case "*":
					result = num1 * num2;
					break;
				case "+":
					result = num1 + num2;
					break;
				case "-":
					result = num1 - num2;
					break;
				default:
					Console.WriteLine("Invalid operator");
					break;
			}

			return result;
		}
	}
}