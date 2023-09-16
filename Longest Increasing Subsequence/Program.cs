using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Increasing_Subsequence
{
	internal class Program
	{
		static void Main()
		{
			List<int> numbers = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToList();

			int[] len = new int[numbers.Count];
			int[] prev = new int[numbers.Count];

			int maxLength = 0;
			int lastIdx = -1;

			for (int i = 0; i < numbers.Count; i++)
			{
				len[i] = 1;
				prev[i] = -1;

				for (int j = 0; j < i; j++)
				{
					if (numbers[j] < numbers[i] && len[j] + 1 > len[i])
					{
						len[i] = len[j] + 1;
						prev[i] = j;
					}
				}

				if (len[i] > maxLength)
				{
					maxLength = len[i];
					lastIdx = i;
				}
			}

			List<int> lis = new List<int>();

			while (lastIdx != -1)
			{
				lis.Insert(0, numbers[lastIdx]);
				lastIdx = prev[lastIdx];
			}

			Console.WriteLine(string.Join(" ", lis));
		}
	}
}