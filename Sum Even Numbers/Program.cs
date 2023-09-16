using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Even_Numbers
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

			int sum = 0;
			for (int i = 0; i < numbersArray.Length; i++)
			{
				int currentNumber = numbersArray[i];
				if (currentNumber % 2 == 0)
				{
					sum += currentNumber;
				}
			}
			
			Console.WriteLine(sum);
		}
	}
}