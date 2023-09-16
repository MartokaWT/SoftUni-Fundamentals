using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cypher
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string inputText = Console.ReadLine();

			string encryptedText = EncryptText(inputText);
			Console.WriteLine(encryptedText);
		}
		static string EncryptText(string inputText)
		{
			char[] encryptedChars = new char[inputText.Length];

			for (int i = 0; i < inputText.Length; i++)
			{
				char currentChar = inputText[i];
				char encryptedChar = (char)(currentChar + 3);

				if (encryptedChar > 126)
				{
					encryptedChar = (char)(currentChar - (127 - 32));
				}

				encryptedChars[i] = encryptedChar;
			}

			return new string(encryptedChars);
		}
	}
}