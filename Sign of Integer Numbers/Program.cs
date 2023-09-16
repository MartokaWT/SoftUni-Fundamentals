using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign_of_Integer_Numbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int input = int.Parse(Console.ReadLine());

			numberCheck(input);
		}

		private static void numberCheck(int input)
		{
			if (input > 0)
			{
				Console.WriteLine($"The number {input} is positive.");
			}
			else if (input < 0)
			{
				Console.WriteLine($"The number {input} is negative.");
			}
			else
			{
				Console.WriteLine($"The number {input} is zero.");
		    }
		}
	}
}