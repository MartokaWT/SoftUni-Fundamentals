using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Easter_Eggs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();

			string pattern = @"(?<color>(?:(?<=@)|(?<=#))[a-z]{3,})(?:[^a-z\d]+)?\/(?<amount>\d+)\/";
			MatchCollection matches = Regex.Matches(text, pattern);

			foreach (Match match in matches)
			{
				string color = match.Groups["color"].Value;
				string amount = match.Groups["amount"].Value;
				Console.WriteLine($"You found {amount} {color} eggs!");
			}
		}
	}
}