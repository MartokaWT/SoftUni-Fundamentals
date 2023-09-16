using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Type_Finder
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input;

			while ((input = Console.ReadLine()) != "END")
			{
				if (int.TryParse(input, out _))
				{
					Console.WriteLine($"{input} is integer type");
				}
				else if (double.TryParse(input, out _))
				{
					Console.WriteLine($"{input} is floating point type");
				}
				else if (bool.TryParse(input, out _))
				{
					Console.WriteLine($"{input} is boolean type");
				}
				else if (char.TryParse(input, out _))
				{
					Console.WriteLine($"{input} is character type");
				}
				else
				{
					Console.WriteLine($"{input} is string type");
				}
			}
		}
	}
}