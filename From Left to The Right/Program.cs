using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From_Left_to_The_Right
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int linesCount = int.Parse(Console.ReadLine());

			for (int i = 0; i < linesCount; i++)
			{
				string line = Console.ReadLine();
				string[] numbers = line.Split(' ');

				int leftNumber = int.Parse(numbers[0]);
				int rightNumber = int.Parse(numbers[1]);

				int leftSum = CalculateDigitSum(leftNumber);
				int rightSum = CalculateDigitSum(rightNumber);

				if (leftNumber > rightNumber)
				{
					Console.WriteLine(leftSum);
				}
				else
				{
					Console.WriteLine(rightSum);
				}
			}

			static int CalculateDigitSum(int number)
			{
				int sum = 0;

				while (number != 0)
				{
					int digit = number % 10;
					sum += digit;
					number /= 10;
				}

				return sum;
			}
		}
	}
}