using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array_of_Strings
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] stringArray = Console
				.ReadLine()
				.Split(' ');

			for (int i = stringArray.Length - 1; i >= 0; i--)
			{
				Console.Write(stringArray[i] + " ");
			}
		}
	}
}