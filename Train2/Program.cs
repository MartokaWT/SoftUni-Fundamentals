using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> wagons = Console.ReadLine()
			.Split(' ', StringSplitOptions.RemoveEmptyEntries)
			.Select(int.Parse)
			.ToList();

			int maxCapacity = int.Parse(Console.ReadLine());

			string input;
			while ((input = Console.ReadLine()) != "end")
			{
				string[] command = input.Split();

				if (command[0] == "Add")
				{
					int passengersToAdd = int.Parse(command[1]);
					wagons.Add(passengersToAdd);
				}
				else
				{
					int passengersToFind = int.Parse(command[0]);

					for (int i = 0; i < wagons.Count; i++)
					{
						int availableSpace = maxCapacity - wagons[i];

						if (availableSpace >= passengersToFind)
						{
							wagons[i] += passengersToFind;
							break;
						}
					}
				}
			}

			Console.WriteLine(string.Join(" ", wagons));
		}
	}
}