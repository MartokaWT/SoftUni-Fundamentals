using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Advanced
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = ReadList();
			bool listChanged = false;

			while (true)
			{
				string command = Console.ReadLine();
				if (command == "end")
					break;

				listChanged = ProcessCommand(command, numbers) || listChanged;
			}

		}
		public static List<int> ReadList()
		{
			string input = Console.ReadLine();
			string[] numbersAsString = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

			List<int> numbers = new List<int>();
			foreach (string num in numbersAsString)
			{
				if (int.TryParse(num, out int parsedNum))
				{
					numbers.Add(parsedNum);
				}
			}

			return numbers;
		}

		public static bool ProcessCommand(string command, List<int> numbers)
		{
			string[] commandParts = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

			if (commandParts.Length == 0)
				return false;

			string action = commandParts[0];

			if (action == "Contains")
			{
				if (commandParts.Length != 2 || !int.TryParse(commandParts[1], out int number))
					return false;

				bool containsNumber = numbers.Contains(number);
				Console.WriteLine(containsNumber ? "Yes" : "No such number");
				return false;
			}
			else if (action == "PrintEven")
			{
				PrintFilteredNumbers(numbers, n => n % 2 == 0);
				return false;
			}
			else if (action == "PrintOdd")
			{
				PrintFilteredNumbers(numbers, n => n % 2 != 0);
				return false;
			}
			else if (action == "GetSum")
			{
				int sum = numbers.Sum();
				Console.WriteLine(sum);
				return false;
			}
			else if (action == "Filter")
			{
				if (commandParts.Length != 3 || !int.TryParse(commandParts[2], out int conditionNumber))
					return false;

				string condition = commandParts[1];
				Func<int, bool> filterCondition = GetFilterCondition(condition, conditionNumber);
				PrintFilteredNumbers(numbers, filterCondition);
				return true;
			}

			return false;
		}

		public static Func<int, bool> GetFilterCondition(string condition, int conditionNumber)
		{
			switch (condition)
			{
				case "<":
					return n => n < conditionNumber;
				case ">":
					return n => n > conditionNumber;
				case "<=":
					return n => n <= conditionNumber;
				case ">=":
					return n => n >= conditionNumber;
				default:
					throw new ArgumentException("Invalid filter condition.");
			}
		}

		public static void PrintFilteredNumbers(List<int> numbers, Func<int, bool> condition)
		{
			List<int> filteredNumbers = numbers.Where(condition).ToList();
			Console.WriteLine(string.Join(" ", filteredNumbers));
		}
	}
}