using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Validator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string password = Console.ReadLine();

			ValidatePassword(password);
		}

		public static void ValidatePassword(string password)
		{
			bool isValid = true;
			if (password.Length < 6 || password.Length > 10)
			{
				Console.WriteLine("Password must be between 6 and 10 characters");
				isValid = false;
			}

			foreach (char c in password)
			{
				if (!char.IsLetterOrDigit(c))
				{
					Console.WriteLine("Password must consist only of letters and digits");
					isValid = false;
					break;
				}
			}

			int digitCount = 0;
			foreach (char c in password)
			{
				if (char.IsDigit(c))
				{
					digitCount++;
					if (digitCount >= 2)
					{
						break;
					}
				}
			}
			if (digitCount < 2)
			{
				Console.WriteLine("Password must have at least 2 digits");
				isValid = false;
			}

			if (isValid)
			{
				Console.WriteLine("Password is valid");
			}
		}
	}
}