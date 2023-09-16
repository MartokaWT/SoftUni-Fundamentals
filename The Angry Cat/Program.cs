using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Angry_Cat
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] priceRatingsInput = Console.ReadLine()
				.Split(',')
				.ToArray();
			int[] priceRatings = new int[priceRatingsInput.Length];
			for (int i = 0; i < priceRatingsInput.Length; i++)
			{
				priceRatings[i] = int.Parse(priceRatingsInput[i]);
			}

			int entryPoint = int.Parse(Console.ReadLine());
			string itemType = Console.ReadLine();

			int leftSum = 0;
			int rightSum = 0;

			for (int i = entryPoint - 1; i >= 0; i--)
			{
				if (itemType == "cheap" && priceRatings[i] < entryPoint)
				{
					leftSum += priceRatings[i];
				}
				else if (itemType == "expensive" && priceRatings[i] >= entryPoint)
				{
					leftSum += priceRatings[i];
				}
			}

			for (int i = entryPoint + 1; i < priceRatings.Length; i++)
			{
				if (itemType == "cheap" && priceRatings[i] < entryPoint)
				{
					rightSum += priceRatings[i];
				}
				else if (itemType == "expensive" && priceRatings[i] >= entryPoint)
				{
					rightSum += priceRatings[i];
				}
			}

			if (leftSum >= rightSum)
			{
				Console.WriteLine($"Left - {leftSum}");
			}
			else
			{
				Console.WriteLine($"Right - {rightSum}");
			}
		}
	}
}