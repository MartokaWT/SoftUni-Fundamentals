using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Integers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			while (input != "END")
			{
				if (IsPositiveInteger(input))
				{
					int number = int.Parse(input);
					bool isPalindrome = IsPalindrome(number);
					Console.WriteLine(isPalindrome ? "true" : "false");
				}

				input = Console.ReadLine();
			}
		}

		public static bool IsPositiveInteger(string input)
		{
			int number;
			return int.TryParse(input, out number) && number >= 0;
		}
		public static bool IsPalindrome(int number)
		{
			int originalNumber = number;
			int reverseNumber = 0;

			while (number > 0)
			{
				int lastDigit = number % 10;
				reverseNumber = reverseNumber * 10 + lastDigit;
				number /= 10;
			}

			return originalNumber == reverseNumber;
		}
	}
}