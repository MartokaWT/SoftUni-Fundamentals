﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Furniture
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string pattern = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
			double income = 0;

			while (true)
			{
				var line = Console.ReadLine();

				if (line == "end of shift")
				{
					break;
				}

				if (Regex.IsMatch(line, pattern))
				{
					Match match = Regex.Match(line, pattern);
					var customer = match.Groups["customer"].Value;
					string product = match.Groups["product"].Value;
					int count = int.Parse(match.Groups["count"].Value);
					double price = double.Parse(match.Groups["price"].Value);
					double money = price * count;
					Console.WriteLine($"{customer}: {product} - {money:F2}");
					income += money;
				}
			}
			Console.WriteLine($"Total income: {income:F2}");
		}
	}
}