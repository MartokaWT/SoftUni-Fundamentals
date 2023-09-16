using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Chars
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int totalSum = 0;

			for (int i = 0; i < n; i++)
			{
				char letter = char.Parse(Console.ReadLine());
				totalSum += (int)letter;
			}

			Console.WriteLine($"The sum equals: {totalSum}");
		}
	}
}