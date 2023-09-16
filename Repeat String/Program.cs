using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat_String
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			int timesRepeated = int.Parse(Console.ReadLine());

			Repeater(input, timesRepeated);
		}

		static void Repeater(string input, int timesRepeated)
		{
			for (int i = 0; i < timesRepeated; i++) 
			{
				string output = input;
				Console.Write($"{output}");
            }
		}
	}
}