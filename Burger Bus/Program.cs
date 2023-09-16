using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Burger_Bus
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int numberOfCities = int.Parse(Console.ReadLine());
			double totalProfit = 0.0;

			for (int i = 1; i <= numberOfCities; i++)
			{
				string cityName = Console.ReadLine();
				double income = double.Parse(Console.ReadLine());
				double expenses = double.Parse(Console.ReadLine());

				double profit = income - expenses;

				if (i % 3 == 0 && i % 5 != 0)
				{
					profit -= expenses * 0.5; // Additional 50% expense for special event
				}
				else if (i % 5 == 0)
				{
					profit -= income * 0.1; // 10% loss due to rain
				}

				totalProfit += profit;

				Console.WriteLine($"In {cityName} Burger Bus earned {profit:F2} leva.");
			}

			Console.WriteLine($"Burger Bus total profit: {totalProfit:F2} leva.");
		}
	}
}