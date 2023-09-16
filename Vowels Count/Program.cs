using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_Count
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string inputString = Console.ReadLine();
			int vowelCount = CountVowels(inputString);
            Console.WriteLine(vowelCount);
        }

		public static int CountVowels(string input)
		{
			input = input.ToLower();

			int vowelCount = 0;
			foreach (char c in input)
			{
				if (IsVowel(c))
				{
					vowelCount++;
				}
			}

			return vowelCount;
		}
		public static bool IsVowel(char c)
		{
			char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

			return Array.Exists(vowels, vowel => vowel == c);
		}
	}
}