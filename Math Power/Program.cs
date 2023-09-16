using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Power
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double number = double.Parse(Console.ReadLine());
			int power = int.Parse(Console.ReadLine());

			Console.WriteLine(RaiseToPower(number, power));
		}

		static double RaiseToPower(double number, int power)
		{
			double result = Math.Pow(number, power);
			return result;
        }
	}
}