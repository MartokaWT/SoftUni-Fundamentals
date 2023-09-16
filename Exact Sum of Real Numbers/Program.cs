using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exact_Sum_of_Real_Numbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			decimal ammount = decimal.Parse(Console.ReadLine());
			decimal sum = 0;

			for (int i = 0; i < ammount; i++)
			{
				decimal input = decimal.Parse(Console.ReadLine());
				sum += input;
            }
			Console.WriteLine($"{sum}");
		}
	}
}