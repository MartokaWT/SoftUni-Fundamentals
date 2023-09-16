using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Numbers_in_Reverse_Order
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] numbers = new int[n];
			

			for (int i = 0; i < numbers.Length; i++)
			{
				numbers[i] = int.Parse(Console.ReadLine());
			}

			for (int i = 0; i < numbers.Length; i++)
			{
				Console.Write(numbers[numbers.Length - 1 - i] + " ");
			}
		}
	}
}