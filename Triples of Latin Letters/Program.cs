using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triples_of_Latin_Letters
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double n = double.Parse(Console.ReadLine());

			for (int i1 = 0; i1 < n; i1++)
				for (int j = 0; j < n; j++)
					for (int f = 0; f < n; f++)
						Console.WriteLine("{0}{1}{2}", (char)('a' + i1), (char)('a' + j), (char)('a' + f));
		}
	}
}