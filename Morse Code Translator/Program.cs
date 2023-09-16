using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse_Code_Translator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, char> morseToEnglish = new Dictionary<string, char>()
			{
				{".-", 'A'}, {"-...", 'B'}, {"-.-.", 'C'}, {"-..", 'D'}, {".", 'E'},
				{"..-.", 'F'}, {"--.", 'G'}, {"....", 'H'}, {"..", 'I'}, {".---", 'J'},
				{"-.-", 'K'}, {".-..", 'L'}, {"--", 'M'}, {"-.", 'N'}, {"---", 'O'},
				{".--.", 'P'}, {"--.-", 'Q'}, {".-.", 'R'}, {"...", 'S'}, {"-", 'T'},
				{"..-", 'U'}, {"...-", 'V'}, {".--", 'W'}, {"-..-", 'X'}, {"-.--", 'Y'},
				{"--..", 'Z'}
			};

			string input = Console.ReadLine();
			string[] words = input.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

			StringBuilder result = new StringBuilder();
			foreach (string word in words)
			{
				string[] characters = word.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				foreach (string morseChar in characters)
				{
					if (morseToEnglish.TryGetValue(morseChar, out char englishChar))
					{
						result.Append(englishChar);
					}
				}
				result.Append(' ');
			}

			Console.WriteLine(result.ToString().Trim());
		}
	}
}