using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decrypting_Message
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int key = int.Parse(Console.ReadLine());
			int n = int.Parse(Console.ReadLine());

			StringBuilder decryptedMessage = new StringBuilder();

			for (int i = 0; i < n; i++)
			{
				char character = char.Parse(Console.ReadLine());
				char decryptedChar = DecryptCharacter(character, key);
				decryptedMessage.Append(decryptedChar);
			}

			Console.WriteLine(decryptedMessage);
		}

		static char DecryptCharacter(char character, int key)
		{
			int decryptedCode = character + key;
			char decryptedChar = (char)decryptedCode;
			return decryptedChar;
		}
	}
}