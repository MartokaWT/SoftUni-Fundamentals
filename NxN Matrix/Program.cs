using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NxN_Matrix
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			PrintMatrix(n);
		}
		public static void PrintMatrix(int n)
		{
			for (int row = 0; row < n; row++)
			{
				for (int col = 0; col < n; col++)
				{
					Console.Write(n + " ");
				}
				Console.WriteLine();
			}
		}
	}
}