using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Match_Phone_Number
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var phoneNumber = Console.ReadLine();

			string pattern = @"(?:\+359)([ -]?)(2)\1\d{3}\1\d{4}\b";

			MatchCollection matches = Regex.Matches(phoneNumber.ToString(), pattern);

			var matchedPhones = matches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
	}
}