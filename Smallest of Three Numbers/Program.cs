 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_of_Three_Numbers
{
	public class Program
	{
		public static void Main(string[] args)
		{
			SmallestNumber();
		}

		public static void SmallestNumber()
		{
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());
			int num3 = int.Parse(Console.ReadLine());

			if (num1 < num2 && num1 < num3)
			{
				Console.WriteLine(num1);
			}
			if (num2 < num1 && num2 < num3)
			{
				Console.WriteLine(num2);
			}
			if (num3 < num1 && num3 < num2)
			{
				Console.WriteLine(num3);
			}
			
		}
	}
}