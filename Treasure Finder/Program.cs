using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Treasure_Finder
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var key = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToList();
			int currentPosition = 0;
			string sequence;
			string regex = @"&(?<type>.+)&[^<]*<(?<coord>.+)>";

			while ((sequence = Console.ReadLine()) != "find")
			{
				int keyLength = key.Count;
				int sequenceLength = sequence.Length;
				var sb = new StringBuilder();

				for (int i = keyLength; i < sequenceLength; i++)
				{
					key.Add(key[currentPosition]);
					currentPosition++;
				}

				for (int i = 0; i < sequenceLength; i++)
				{
					sb.Append((char)(sequence[i] - key[i]));
				}

				Match m = Regex.Match(sb.ToString(), regex);

				if (m.Success)
				{
					string type = m.Groups["type"].Value;
					string coord = m.Groups["coord"].Value;
					Console.WriteLine($"Found {type} at {coord}");
				}
			}
		}
	}
}