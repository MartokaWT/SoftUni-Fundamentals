using System;

namespace Data_Types
{
	public class Program
	{
		static void Main(string[] args)
		{
			string dataType = Console.ReadLine();

			if (dataType == "int")
			{
				int number = int.Parse(Console.ReadLine());
				int result = Multiply(number);
				Console.WriteLine(result);
			}
			else if (dataType == "real")
			{
				double number = double.Parse(Console.ReadLine());
				double result = Multiply(number);
				Console.WriteLine($"{result:F2}");
			}
			else if (dataType == "string")
			{
				string input = Console.ReadLine();
				string result = Multiply(input);
				Console.WriteLine(result);
			}

		}
		static int Multiply(int number)
		{
			return number * 2;
		}

		static double Multiply(double number)
		{
			return number * 1.5;
		}

		static string Multiply(string input)
		{
			return $"${input}$";
		}
	}
}