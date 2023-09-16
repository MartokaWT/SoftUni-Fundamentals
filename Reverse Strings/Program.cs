using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Strings
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			while (input != "end")
			{
				var reversedString = input.ToArray().Reverse();

			}
			Console.WriteLine($"{input} = {string.Join("", reversedString)}");

		}
	}
}