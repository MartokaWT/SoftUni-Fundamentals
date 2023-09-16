using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Word_Filter
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] words = Console.ReadLine()
				.Split()
				.Where(w => w.Length % 2 == 0)
				.ToArray();

            foreach (string word in words)
			{
                Console.WriteLine(word);
            }
        }
	}
}