using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTML
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string title = Console.ReadLine();
			string content = Console.ReadLine();

			StringBuilder comments = new StringBuilder();
			string input;
			while ((input = Console.ReadLine()) != "end of comments")
			{
				comments.AppendLine($"<div>\n    {input}\n</div>");
			}

			Console.WriteLine($"<h1>\n    {title}\n</h1>");
			Console.WriteLine($"<article>\n    {content}\n</article>");
			Console.WriteLine(comments);
		}
	}
}