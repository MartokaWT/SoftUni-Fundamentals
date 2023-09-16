using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tribonacci_Sequence
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());

			if (num <= 0)
			{
				return;
			}

			int[] tribonacci = new int[num];
			tribonacci[0] = 1;

			if (num > 1)
			{
				tribonacci[1] = 1;
			}

			if (num > 2)
			{
				tribonacci[2] = 2;
			}

			for (int i = 3; i < num; i++)
			{
				tribonacci[i] = tribonacci[i - 1] + tribonacci[i - 2] + tribonacci[i - 3];
			}

			Console.WriteLine(string.Join(" ", tribonacci));
		}
	}
}