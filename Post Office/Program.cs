﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Post_Office
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] symbols = Console.ReadLine()
				.Split('|')
				.ToArray();

			string patternOne = @"(\$|#|%|\*|&)(?<capitalLetters>[A-Z]+)(\1)";
			string patternTwo = @"([0-9][0-9]):([0-9][0-9])";
			Match matchLetters = Regex.Match(symbols[0], patternOne);
			string allLetters = matchLetters.Groups["capitalLetters"].Value;
			MatchCollection matchesNumbers = Regex.Matches(symbols[1], patternTwo);


			var letters = new Dictionary<char, int>();
			foreach (char letter in allLetters)
			{
				foreach (Match digits in matchesNumbers)
				{
					string firstDigit = digits.Groups[1].Value;
					int firstLetterInt = int.Parse(firstDigit);
					char firstLetterChar = (char)firstLetterInt;
					string wordLength = digits.Groups[2].Value;
					int wordLengthInt = int.Parse(wordLength);

					if (letter == firstLetterChar && letters.ContainsKey(letter) == false)
					{
						letters[letter] = wordLengthInt + 1;
						break;
					}
				}
			}



			string[] words = symbols[2].Split(' ').ToArray();

			foreach (var kvp in letters)
			{
				char letter = kvp.Key;
				int wordLength = kvp.Value;

				foreach (string word in words)
				{
					char currentFirstLetter = word[0];
					int currentWordLength = word.Length;

					if (letter == currentFirstLetter && wordLength == currentWordLength)
					{
						Console.WriteLine(word);
						break;
					}
				}
			}
		}
	}
}