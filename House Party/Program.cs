using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Party
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int numberOfCommands = int.Parse(Console.ReadLine());
			HashSet<string> guestList = new HashSet<string>();

			for (int i = 0; i < numberOfCommands; i++)
			{
				string input = Console.ReadLine();
				string[] command = input.Split();

				string name = command[0];
				string action = command[2];

				if (action == "going!")
				{
					if (guestList.Contains(name))
					{
						Console.WriteLine($"{name} is already in the list!");
					}
					else
					{
						guestList.Add(name);
					}
				}
				else if (action == "not")
				{
					if (guestList.Contains(name))
					{
						guestList.Remove(name);
					}
					else
					{
						Console.WriteLine($"{name} is not in the list!");
					}
				}
			}

			foreach (string guest in guestList)
			{
				Console.WriteLine(guest);
			}
		}
	}
}