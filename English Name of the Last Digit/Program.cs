using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_Name_of_the_Last_Digit
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			string lastDigitSpelling = GetLastDigitSpelling(number);
			Console.WriteLine(lastDigitSpelling);
		}
		static string GetLastDigitSpelling(int number)
		{
			int lastDigit = Math.Abs(number % 10);

			switch (lastDigit)
			{
				case 0:
					return "zero";
				case 1:
					return "one";
				case 2:
					return "two";
				case 3:
					return "three";
				case 4:
					return "four";
				case 5:
					return "five";
				case 6:
					return "six";
				case 7:
					return "seven";
				case 8:
					return "eight";
				case 9:
					return "nine";
				default:
					return "Invalid number";
			}

		}
	}
}