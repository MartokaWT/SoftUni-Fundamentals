using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomize_Words
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			var words = Console.ReadLine()
				.Split()
				.ToArray();

			for (int i = 0; i < words.Length; i++)
			{
				var randomIndex = rnd.Next(0, words.Length);


				var a = words[randomIndex];
				var b = words[i];

				words[randomIndex] = b;
				words[i] = a;
			}

			foreach (var item in words)
			{
				Console.WriteLine(item);
			}
		}
	}
}