using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle_Characters
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			PrintMiddleCharacter(input);
		}

		public static void PrintMiddleCharacter(string input)
		{
			int length = input.Length;

			if (length % 2 == 0)
			{
				int middleIndex1 = length / 2 - 1;
				int middleIndex2 = length / 2;

				Console.WriteLine($"{input[middleIndex1]}{input[middleIndex2]}");
			}
			else
			{
				int middleIndex = length / 2;

				Console.WriteLine($"{input[middleIndex]}");
			}
		}
	}
}