using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Valid_Usernames
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string[] usernames = input.Split(", ");

			foreach (string username in usernames)
			{
				if (IsUsernameValid(username))
				{
					Console.WriteLine(username);
				}
			}
		}

		static bool IsUsernameValid(string username)
		{
			if (username.Length < 3 || username.Length > 16)
			{
				return false;
			}

			Regex regex = new Regex("^[a-zA-Z0-9_-]+$");
			return regex.IsMatch(username);
		}
	}
}