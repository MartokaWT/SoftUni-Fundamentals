using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Filter
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] banList = Console.ReadLine().Split(", ");
			string text = Console.ReadLine();

			foreach (string banWord in banList)
			{
				string replacement = new string('*', banWord.Length);
				text = text.Replace(banWord, replacement);
			}

			Console.WriteLine(text);
		}
	}
}