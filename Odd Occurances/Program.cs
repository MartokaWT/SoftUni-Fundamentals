﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Occurances
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] words = Console.ReadLine()
				.Split();

			Dictionary<string, int> counts = new Dictionary<string, int>();

			foreach (string word in words)  
			{
				string wordInLowerCase = word.ToLower();
				if (counts.ContainsKey(wordInLowerCase))
				{
					counts[wordInLowerCase]++;
				}
				else
				{
					counts.Add(wordInLowerCase, 1);
				}
			}

			foreach (var count in counts)
			{
				if (count.Value % 2 != 0)
				{
					Console.WriteLine(count.Key + " ");
				}
			}
		}
	}
}