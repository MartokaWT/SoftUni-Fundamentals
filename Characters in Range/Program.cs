using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters_in_Range
{
	internal class Program
	{
		static void Main(string[] args)
		{
			char firstChar = char.Parse(Console.ReadLine());
			char secondChar = char.Parse(Console.ReadLine());

			string charactersInRange = GetCharactersInRange(firstChar, secondChar);
			Console.WriteLine(charactersInRange);
		}

		public static string GetCharactersInRange(char firstChar, char secondChar)
		{
			if (secondChar < firstChar)
			{
				char temp = firstChar;
				firstChar = secondChar;
				secondChar = temp;
			}

			System.Text.StringBuilder sb = new System.Text.StringBuilder();

			for (char c = (char)(firstChar + 1); c < secondChar; c++)
			{
				sb.Append(c);
				sb.Append(" ");
			}

			return sb.ToString();
		}
	}		
}