using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_and_Odd_Subtraction
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] numbersArray = Console
				.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();

			int evenSum = 0;
			int oddSum = 0;
			for (int i = 0; i < numbersArray.Length; i++)
			{
				int currentNumber = numbersArray[i];
				if (currentNumber % 2 == 0)
				{
					evenSum += currentNumber;
				}
				else
				{
					oddSum += currentNumber;
				}

            }

			int difference = evenSum - oddSum;
			Console.WriteLine(difference);
		}
	}
}