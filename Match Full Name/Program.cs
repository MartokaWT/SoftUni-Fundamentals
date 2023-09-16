using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Match_Full_Name
{
	internal class Name
	{

	}

	internal class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();

			var pattern = new Regex(@"(\b[A-Z][a-z]+) ([A-Z][a-z]+)");

			MatchCollection match = pattern.Matches(input);

			foreach (Match item in match)
			{
				Console.Write($"{item}" + " ");
			}
		}
	}
}