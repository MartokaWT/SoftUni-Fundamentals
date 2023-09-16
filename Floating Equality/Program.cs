using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floating_Equality
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double eps = 0.000001;

			double a = double.Parse(Console.ReadLine());

			double b = double.Parse(Console.ReadLine());

			bool areEqual = Math.Abs(a - b) < eps;

			Console.WriteLine($"{areEqual}");
		}
	}
}