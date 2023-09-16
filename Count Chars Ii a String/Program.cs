using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Chars_Ii_a_String
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			var charCounts = new Dictionary<char, int>();

			foreach (char c in input)
			{
				if (c == ' ')
					continue;

				if (charCounts.ContainsKey(c))
					charCounts[c]++;
				else
					charCounts[c] = 1;
			}

			foreach (var pair in charCounts)
			{
				Console.WriteLine($"{pair.Key} -> {pair.Value}");
			}
		}
	}
}