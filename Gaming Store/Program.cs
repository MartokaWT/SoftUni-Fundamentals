using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Store
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double currentBalance = double.Parse(Console.ReadLine());
			double totalSpent = 0;

			while (true)
			{
				string game = Console.ReadLine();
				if (game == "Game Time")
				{
					break;
				}

				switch (game)
				{
					case "OutFall 4":
						if (currentBalance >= 39.99)
						{
							Console.WriteLine("Bought OutFall 4");
							currentBalance -= 39.99;
							totalSpent += 39.99;
						}
						else
						{
							Console.WriteLine("Too Expensive");
						}
						break;
					case "CS: OG":
						if (currentBalance >= 15.99)
						{
							Console.WriteLine("Bought CS: OG");
							currentBalance -= 15.99;
							totalSpent += 15.99;
						}
						else
						{
							Console.WriteLine("Too Expensive");
						}
						break;
					case "Zplinter Zell":
						if (currentBalance >= 19.99)
						{
							Console.WriteLine("Bought Zplinter Zell");
							currentBalance -= 19.99;
							totalSpent += 19.99;
						}
						else
						{
							Console.WriteLine("Too Expensive");
						}
						break;
					case "Honored 2":
						if (currentBalance >= 59.99)
						{
							Console.WriteLine("Bought Honored 2");
							currentBalance -= 59.99;
							totalSpent += 59.99;
						}
						else
						{
							Console.WriteLine("Too Expensive");
						}
						break;
					case "RoverWatch":
						if (currentBalance >= 29.99)
						{
							Console.WriteLine("Bought RoverWatch");
							currentBalance -= 29.99;
							totalSpent += 29.99;
						}
						else
						{
							Console.WriteLine("Too Expensive");
						}
						break;
					case "RoverWatch Origins Edition":
						if (currentBalance >= 39.99)
						{
							Console.WriteLine("Bought RoverWatch Origins Edition");
							currentBalance -= 39.99;
							totalSpent += 39.99;
						}
						else
						{
							Console.WriteLine("Too Expensive");
						}
						break;
					default:
						Console.WriteLine("Not Found");
						break;
				}

				if (currentBalance <= 0)
				{
					Console.WriteLine("Out of money!");
					break;
				}
			}

			Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${currentBalance:F2}");
		}
	}
}