using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Big_Number
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string bigNumberStr = Console.ReadLine();
			int singleDigit = int.Parse(Console.ReadLine());

			string result = MultiplyBigNumberWithSingleDigit(bigNumberStr, singleDigit);
			Console.WriteLine(result);
		}
		static string MultiplyBigNumberWithSingleDigit(string bigNumberStr, int singleDigit)
		{
			int carry = 0;
			int n = bigNumberStr.Length;
			char[] resultChars = new char[n + 1];

			for (int i = n - 1; i >= 0; i--)
			{
				int digit = bigNumberStr[i] - '0';
				int product = digit * singleDigit + carry;

				resultChars[i + 1] = (char)(product % 10 + '0');
				carry = product / 10;
			}

			resultChars[0] = (char)(carry + '0');

			int start = 0;
			while (start < resultChars.Length - 1 && resultChars[start] == '0')
			{
				start++;
			}

			return new string(resultChars, start, resultChars.Length - start);
		}
	}
}