using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Big_Factorial
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			BigInteger f = 1;

			for (int i = 2; i <= n; i++)
			{
				f = f * i;
			}

			Console.WriteLine(f);
			Console.ReadLine();
		}
	}
}