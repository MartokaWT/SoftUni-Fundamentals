using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Sign
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());
			int num3 = int.Parse(Console.ReadLine());

			int[] numbers = { num1, num2, num3 };
			int negativeCount = 0;

			foreach (int num in numbers)
			{
				if (num == 0)
				{
					return;
				}
				else if (num < 0)
				{
					negativeCount++;
				}
			}

			if (negativeCount % 2 == 0)
			{
				Console.WriteLine("positive");
			}
			else
			{
				Console.WriteLine("negative");
			}
		}
	}
}