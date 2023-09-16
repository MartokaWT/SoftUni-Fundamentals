using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits_Letters_and_Others
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			string digits = "";
			string letters = "";
			string others = "";

			foreach (char symbol in input)
			{
				if (char.IsDigit(symbol))
				{
					digits += symbol;
				}
				else if (char.IsLetter(symbol))
				{
					letters += symbol;
				}
				else
				{
					others += symbol;
				}
			}

			Console.WriteLine(digits);
			Console.WriteLine(letters);
			Console.WriteLine(others);
		}
	}
}