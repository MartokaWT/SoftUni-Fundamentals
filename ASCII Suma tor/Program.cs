﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Suma_tor
{
	internal class Program
	{
		static void Main(string[] args)
		{
			char start = char.Parse(Console.ReadLine());
			char end = char.Parse(Console.ReadLine());
			string str = Console.ReadLine();
			int sum = 0;
			for (int i = 0; i < str.Length; i++)
			{
				if (str[i] > start && str[i] < end) sum += str[i];
			}
			Console.WriteLine(sum);
		}
	}
}