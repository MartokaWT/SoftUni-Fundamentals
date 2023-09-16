using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_Numbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			if (n >= 1 && n <= 20)
			{
				for (int i = 1; i <= n; i++)
				{
					for (int j = 1; j <= i; j++)
					{
						Console.Write(i + " ");
					}
					Console.WriteLine();
				}
			}
		}
	}
}