using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Manipulation_Basics
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			List<int> numbers = ParseInputToList(input);

			while (true)
			{
				string command = Console.ReadLine();

				if (command == "end")
				{
					break;
				}

				ProcessCommand(numbers, command);
			}

			Console.WriteLine(string.Join(" ", numbers));
		}
		public static List<int> ParseInputToList(string input)
		{
			List<int> numbers = new List<int>();
			string[] numberStrings = input.Split(' ');

			foreach (string numberString in numberStrings)
			{
				if (int.TryParse(numberString, out int number))
				{
					numbers.Add(number);
				}
			}

			return numbers;
		}
		public static void ProcessCommand(List<int> numbers, string command)
		{
			string[] tokens = command.Split(' ');
			string action = tokens[0];

			switch (action)
			{
				case "Add":
					if (int.TryParse(tokens[1], out int numberToAdd))
					{
						numbers.Add(numberToAdd);
					}
					break;

				case "Remove":
					if (int.TryParse(tokens[1], out int numberToRemove))
					{
						numbers.Remove(numberToRemove);
					}
					break;

				case "RemoveAt":
					if (int.TryParse(tokens[1], out int indexToRemove))
					{
						numbers.RemoveAt(indexToRemove);
					}
					break;

				case "Insert":
					if (int.TryParse(tokens[1], out int numberToInsert) && int.TryParse(tokens[2], out int indexToInsert))
					{
						numbers.Insert(indexToInsert, numberToInsert);
					}
					break;
			}
		}
	}
}