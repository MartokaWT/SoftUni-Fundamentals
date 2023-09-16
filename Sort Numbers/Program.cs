using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Numbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double num1 = double.Parse(Console.ReadLine());
			double num2 = double.Parse(Console.ReadLine());
			double num3 = double.Parse(Console.ReadLine());

			double[] numbers = { num1, num2, num3 };
			Array.Sort(numbers, (a, b) => b.CompareTo(a));

			foreach (double num in numbers)
			{
				Console.WriteLine(num);
			}
		}
	}
}