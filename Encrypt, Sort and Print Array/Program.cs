using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt__Sort_and_Print_Array
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			List<int> encryptedNumbers = new List<int>();

			for (int i = 0; i < n; i++)
			{
				string input = Console.ReadLine();

				int encryptedNumber = EncryptString(input);
				encryptedNumbers.Add(encryptedNumber);
			}

			encryptedNumbers.Sort();

			foreach (int number in encryptedNumbers)
			{
				Console.WriteLine(number);
			}
		}

		static int EncryptString(string input)
		{
			int vowelSum = 0;
			int consonantSum = 0;
			int stringLength = input.Length;

			foreach (char ch in input)
			{
				if (IsVowel(ch))
				{
					vowelSum += (int)ch * stringLength;
				}
				else
				{
					consonantSum += (int)ch / stringLength;
				}
			}

			return vowelSum + consonantSum;
		}

		static bool IsVowel(char ch)
		{
			ch = char.ToLower(ch);
			return ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u';
		}
	}
}