using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Negatives_and_Reverse
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			List<int> numbers = ParseInputToList(input);

			numbers.RemoveAll(num => num < 0);

			if (numbers.Count > 0)
			{
				numbers.Reverse();
				Console.WriteLine(string.Join(" ", numbers));
			}
			else
			{
				Console.WriteLine("empty");
			}
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
	}
}