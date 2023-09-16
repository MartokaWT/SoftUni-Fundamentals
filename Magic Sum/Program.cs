using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Sum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();

			int magicNumber = int.Parse(Console.ReadLine());

			for (int i = 0; i < input.Length - 1; i++)
			{
				for (int j = i + 1; j < input.Length; j++)
				{
					if (input[i] + input[j] == magicNumber)
					{
						Console.WriteLine($"{input[i]} {input[j]}");
					}
				}
			}
		}
	}
}