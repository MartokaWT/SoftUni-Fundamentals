using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Top_Integers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			long[] array = Console.ReadLine()
				.Split()
				.Select(long.Parse)
				.ToArray();

			for (long i = 0; i < array.Length; i++)
			{
				bool isItBigger = true;
				for (long j = i + 1; j < array.Length; j++)
				{
					if (array[i] <= array[j])
					{
						isItBigger = false;
					}
				}

				if (isItBigger)
				{
					Console.Write(array[i] + " ");
				}
			}
		}
	}
}