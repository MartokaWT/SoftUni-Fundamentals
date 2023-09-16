using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles_2._0
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			List<Article> articles = new List<Article>();

			for (int i = 0; i < n; i++)
			{
				string[] articleInfo = Console.ReadLine().Split(", ");
				string title = articleInfo[0];
				string content = articleInfo[1];
				string author = articleInfo[2];

				Article article = new Article(title, content, author);
				articles.Add(article);
			}

			foreach (var article in articles)
			{
				Console.WriteLine(article);
			}
		}

		class Article
		{
			public string Title { get; set; }
			public string Content { get; set; }
			public string Author { get; set; }

			public Article(string title, string content, string author)
			{
				Title = title;
				Content = content;
				Author = author;
			}

			public override string ToString()
			{
				return $"{Title} - {Content}: {Author}";
			}
		}
	}
}