using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int linesCount = int.Parse(Console.ReadLine());

			string smsText = "";

			for (int i = 0; i < linesCount; i++)
			{
				string line = Console.ReadLine();

				string currentLetter = string.Empty;
				int prevDigit = -1;
				int currentLetterIndex = -1;

				foreach (char digit in line)
				{
					int currentDigit = digit - '0';

					if (currentDigit == 0)
					{
						smsText += " ";
					}
					else
					{
						int offset = (currentDigit - 2) * 3;
						if (currentDigit >= 8)
						{
							offset++;
						}

						currentLetterIndex = offset + line.Length - 1;

						if (currentDigit == prevDigit)
						{
							currentLetter = currentLetter[currentLetterIndex].ToString();
						}
						else
						{
							currentLetter = ((char)(97 + currentLetterIndex)).ToString();
						}

						smsText += currentLetter;
					}

					prevDigit = currentDigit;
				}
			}

			Console.WriteLine("SMS: " + smsText);
		}
	}
}