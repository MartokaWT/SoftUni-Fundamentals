using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding_Numbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double[] array = Console
				.ReadLine()
				.Split()
				.Select(double.Parse)
				.ToArray();

			foreach (double number in array)
			{
				int rounded = (int)Math.Round(number, MidpointRounding.AwayFromZero);
				Console.WriteLine($"{number} => {rounded}");
			}
		}
	}
}