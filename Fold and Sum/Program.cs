using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_Sum
{
	internal class Program
	{
		static void Main()
		{
			int k = int.Parse(Console.ReadLine());
			int[] array = new int[4 * k];

			for (int i = 0; i < 4 * k; i++)
			{
				array[i] = int.Parse(Console.ReadLine());
			}

			int[] foldedArray = FoldArrayAndSumRows(array, k);

			Console.WriteLine(string.Join(" ", foldedArray));
		}

		static int[] FoldArrayAndSumRows(int[] array, int k)
		{
			int[] foldedArray = new int[2 * k];

			for (int i = 0; i < k; i++)
			{
				foldedArray[i] = array[k - 1 - i] + array[4 * k - 1 - i];
			}

			for (int i = 0; i < 2 * k; i++)
			{
				foldedArray[i] += array[k + i];
			}

			return foldedArray;
		}
	}
}