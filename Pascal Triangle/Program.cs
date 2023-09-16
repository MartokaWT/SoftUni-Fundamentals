using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascal_Triangle
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int numRows = int.Parse(Console.ReadLine());

			for (int row = 0; row < numRows; row++)
			{
				int currentValue = 1;

				for (int col = 0; col <= row; col++)
				{
					Console.Write(currentValue + " ");

					currentValue = currentValue * (row - col) / (col + 1);
				}

				Console.WriteLine();
			}
		}
	}
}