using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santa_s_Secret_Helper
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int key = int.Parse(Console.ReadLine());
			List<string> messages = new List<string>();

			while (true)
			{
				string message = Console.ReadLine();
				if (message == "end")
					break;
				messages.Add(message);
			}

			List<string> goodChildren = GetGoodChildren(key, messages);

			foreach (string childName in goodChildren)
			{
				Console.WriteLine(childName);
			}
		}
		static bool IsValidMessage(string msg)
		{
			int nameStart = msg.IndexOf('@') + 1;
			int behaviorStart = msg.IndexOf('!') + 1;

			string name = msg.Substring(nameStart, behaviorStart - nameStart - 1);
			char behavior = msg[behaviorStart];

			return IsLatinAlphabet(name) && (behavior == 'G' || behavior == 'N');
		}

		static bool IsLatinAlphabet(string input)
		{
			foreach (char c in input)
			{
				if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')))
					return false;
			}
			return true;
		}

		static string DecryptMessage(string msg, int key)
		{
			StringBuilder decryptedMsg = new StringBuilder();
			foreach (char c in msg)
			{
				if (c == '@' || c == '-' || c == '!' || c == ':' || c == '>')
				{
					decryptedMsg.Append(c);
				}
				else
				{
					char decryptedChar = (char)(c - key);
					decryptedMsg.Append(decryptedChar);
				}
			}
			return decryptedMsg.ToString();
		}

		static List<string> GetGoodChildren(int key, List<string> messages)
		{
			List<string> goodChildren = new List<string>();

			foreach (string msg in messages)
			{
				string decryptedMsg = DecryptMessage(msg, key);
				if (IsValidMessage(decryptedMsg))
				{
					int nameStart = decryptedMsg.IndexOf('@') + 1;
					int behaviorStart = decryptedMsg.IndexOf('!') + 1;
					string name = decryptedMsg.Substring(nameStart, behaviorStart - nameStart - 1);
					goodChildren.Add(name);
				}
			}

			return goodChildren;
		}

	}
}