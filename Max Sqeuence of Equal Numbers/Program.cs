using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sqeuence_of_Equal_Numbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine()
							.Split()
							.Select(int.Parse)
							.ToArray();
			int counter = 0;
			int winningCounter = 0;
			int index = 0;
			string number = string.Empty;

			for (int i = 0; i < numbers.Length - 1; i++)
			{
				if (numbers[i] == numbers[i + 1])
				{
					counter++;
					if (counter > winningCounter)
					{
						winningCounter = counter;
						index = i;
						number = numbers[i].ToString();
					}
				}
				else
				{
					counter = 0;
				}
			}
			for (int i = 0; i <= winningCounter; i++)
			{
				Console.Write(number + " ");
			}
		}
	}
}