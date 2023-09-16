using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_List
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine()
			.Split(' ', StringSplitOptions.RemoveEmptyEntries)
			.Select(int.Parse)
			.ToList();

			string input;
			while ((input = Console.ReadLine()) != "end")
			{
				string[] command = input.Split();

				if (command[0] == "Delete")
				{
					int elementToDelete = int.Parse(command[1]);
					numbers.RemoveAll(num => num == elementToDelete);
				}
				else if (command[0] == "Insert")
				{
					int elementToInsert = int.Parse(command[1]);
					int position = int.Parse(command[2]);
					numbers.Insert(position, elementToInsert);
				}
			}

			Console.WriteLine(string.Join(" ", numbers));
		}
	}
}