using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_Operations
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());
			int num3 = int.Parse(Console.ReadLine());
			int num4 = int.Parse(Console.ReadLine());

			int operation1 = num1 + num2;
			int operation2 = operation1 / num3;
			int operation3 = operation2 * num4;

            Console.WriteLine(operation3);
        }
	}
}