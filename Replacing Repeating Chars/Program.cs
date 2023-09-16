using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replacing_Repeating_Chars
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string result = RemoveDuplicates(input);

			Console.WriteLine(result);
		}
		static string RemoveDuplicates(string input)
		{
			if (string.IsNullOrEmpty(input))
				return input;

			StringBuilder sb = new StringBuilder();
			char prevChar = input[0];
			sb.Append(prevChar);

			for (int i = 1; i < input.Length; i++)
			{
				char currentChar = input[i];

				if (currentChar != prevChar)
				{
					sb.Append(currentChar);
					prevChar = currentChar;
				}
			}

			return sb.ToString();
		}
	}
}