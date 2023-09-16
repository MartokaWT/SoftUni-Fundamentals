using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoftUni_Bar_Income
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input;
			string pattern = @"%(?<clientname>[A-Z]{1}[a-z]+)%\w*<(?<product>\w+)>\w*\|(?<quantity>[0-9]+)\|[\W]*(?<price>[0-9]+.[0-9]{1})\$|\%([A-Z]{1}[a-z]+)%\w*<(\w+)>\w*\|([0-9]+)\|\W*([0-9]+)\$";
			double totalIncome = 0;
			while ((input = Console.ReadLine()) != "end of shift")
			{
				Regex rg = new Regex(pattern);
				MatchCollection mc = rg.Matches(input);
				foreach (Match m in mc)
				{
					string clientName = m.Groups["clientname"].Value;
					string product = m.Groups["product"].Value;
					double quantity = double.Parse(m.Groups["quantity"].Value);
					double price = double.Parse(m.Groups["price"].Value);
					Console.WriteLine($"{clientName}: {product} - {quantity * price:f2}");
					totalIncome += quantity * price;
				}
			}
			Console.WriteLine($"Total income: {totalIncome:F2}");
		}
	}
}