using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			string reversedString = Reverse(input);
			Console.WriteLine(reversedString);
		}
		static string Reverse(string str)
		{
			char[] charArray = str.ToCharArray();
			Array.Reverse(charArray);
			return new string(charArray);
		}
	}
}