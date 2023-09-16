using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Meters_to_Kilometers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double input = double.Parse(Console.ReadLine());

			double output = input / 1000;
			Console.WriteLine($"{output:f2}");
		}
	}
}