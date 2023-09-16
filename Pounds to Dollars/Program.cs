using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pounds_to_Dollars
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double inputPounds = double.Parse(Console.ReadLine());
			double outputDollars = inputPounds * 1.31;
            Console.WriteLine($"{outputDollars:f3}");

        }
	}
}