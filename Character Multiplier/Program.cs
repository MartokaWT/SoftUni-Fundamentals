using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Multiplier
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string str1 = Console.ReadLine();
			string str2 = Console.ReadLine();

			int result = CalculateCharacterCodeSum(str1, str2);
			Console.WriteLine(result);
		}
		public static int CalculateCharacterCodeSum(string str1, string str2)
		{
			int sum = 0;
			int minLength = Math.Min(str1.Length, str2.Length);

			for (int i = 0; i < minLength; i++)
			{
				sum += str1[i] * str2[i];
			}

			for (int i = minLength; i < str1.Length; i++)
			{
				sum += str1[i];
			}

			for (int i = minLength; i < str2.Length; i++)
			{
				sum += str2[i];
			}

			return sum;
		}
	}
}