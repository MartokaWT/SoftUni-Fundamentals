﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lower_or_Upper
{
	internal class Program
	{
		static void Main(string[] args)
		{
			char input = char.Parse(Console.ReadLine());

			if (input >= 65 && input <= 90)
			{
				Console.WriteLine("upper-case");
			}
			else
			{
				Console.WriteLine("lower-case");
			}
		}
	}
}