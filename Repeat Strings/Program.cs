using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat_Strings
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split();

			StringBuilder result = new StringBuilder();

			foreach (string word in input)
			{
				int count = word.Length;

				for (int i = 0; i < count; i++)
				{
					result.Append(word);
				}
			}

			Console.WriteLine(result.ToString());
		}
	}
}