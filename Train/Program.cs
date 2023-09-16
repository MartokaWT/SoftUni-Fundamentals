using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] wagons = new int[n];

			for (int i = 0; i < n; i++)
			{
				wagons[i] = int.Parse(Console.ReadLine());
            }

			for (int i = 0; i < wagons.Length; i++)
			{
				Console.Write(wagons[i] + " ");
            }

			int sum = wagons.Sum();
			Console.WriteLine($"\n{sum}");
		}
	}
}