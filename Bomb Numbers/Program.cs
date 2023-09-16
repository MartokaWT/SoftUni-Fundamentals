using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomb_Numbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine()
			.Split(' ', StringSplitOptions.RemoveEmptyEntries)
			.Select(int.Parse)
			.ToList();

			int[] bombParams = Console.ReadLine()
				.Split(' ', StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			int bombNumber = bombParams[0];
			int bombPower = bombParams[1];

			while (numbers.Contains(bombNumber))
			{
				int bombIndex = numbers.IndexOf(bombNumber);
				int startIndex = Math.Max(0, bombIndex - bombPower);
				int endIndex = Math.Min(numbers.Count - 1, bombIndex + bombPower);

				numbers.RemoveRange(startIndex, endIndex - startIndex + 1);
			}

			int sumRemainingNumbers = numbers.Sum();
			Console.WriteLine(sumRemainingNumbers);
		}
	}
}