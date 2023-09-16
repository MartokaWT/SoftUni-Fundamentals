using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string username = Console.ReadLine();
			string password = ReverseString(username);

			while (true)
			{
				string inputPassword = Console.ReadLine();

				if (inputPassword == password)
				{
					Console.WriteLine($"User {username} logged in.");
					break;
				}
				else
				{
					Console.WriteLine("Incorrect password. Try again.");
				}
			}
		}
		static string ReverseString(string str)
		{
			char[] charArray = str.ToCharArray();
			Array.Reverse(charArray);
			return new string(charArray);
		}
	}
}