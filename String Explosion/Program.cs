using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Explosion
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			string result = ProcessExplosions(input);
			Console.WriteLine(result);
		}
		static string ProcessExplosions(string input)
		{
			StringBuilder sb = new StringBuilder();

			int strength = 0;

			for (int i = 0; i < input.Length; i++)
			{
				char currentChar = input[i];

				if (currentChar == '>')
				{
					int nextIndex = i + 1;

					if (nextIndex < input.Length && char.IsDigit(input[nextIndex]))
					{
						strength += int.Parse(input[nextIndex].ToString());
					}

					sb.Append(currentChar);
				}
				else
				{
					if (strength == 0)
					{
						sb.Append(currentChar);
					}
					else
					{
						strength--;
					}
				}
			}

			return sb.ToString();
		}
	}
}