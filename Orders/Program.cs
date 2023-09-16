using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string product = Console.ReadLine();
			int quantity = int.Parse(Console.ReadLine());
			double totalCost = 0;

			priceCalculation(product, quantity, totalCost);
		}

		static void priceCalculation(string product, int quantity, double totalCost)
		{
			if (product == "coffee")
			{
				double coffee = 1.50;
				totalCost = coffee * quantity;
				Console.WriteLine($"{totalCost:f2}");
			}
			else if (product == "water")
			{
				double water = 1.00;
				totalCost = water * quantity;
				Console.WriteLine($"{totalCost:f2}");
			}
			else if (product == "coke")
			{
				double coke = 1.40;
				totalCost = coke * quantity;
				Console.WriteLine($"{totalCost:f2}");
			}
			else if (product == "snacks")
			{
				double snacks = 2.00;
				totalCost = snacks * quantity;
				Console.WriteLine($"{totalCost:f2}");
			}
		}
	}
}