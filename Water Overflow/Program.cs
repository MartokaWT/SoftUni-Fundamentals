using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Overflow
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int tankCapacity = 255;
			int currentLiters = 0;

			for (int i = 0; i < n; i++)
			{
				int litersToAdd = int.Parse(Console.ReadLine());

				if (currentLiters + litersToAdd > tankCapacity)
				{
					Console.WriteLine("Insufficient capacity!");
				}
				else
				{
					currentLiters += litersToAdd;
				}
			}

			Console.WriteLine(currentLiters);
		}
	}
}