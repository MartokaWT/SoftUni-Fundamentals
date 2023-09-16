using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Triangle
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int input = int.Parse(Console.ReadLine());
			PrintTriangle(input);
		}

		static void PrintLine(int start, int end)
		{
			for (int i = start; i <= end; i++)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();
		}

		static void PrintTriangle(int input)
		{
			for (int line = 1; line <= input; line++)
			{
				PrintLine(1, line);
			}

			for (int line = input - 1; line >= 1; line--)
			{
				PrintLine(1, line);
			}
		}
	}
}