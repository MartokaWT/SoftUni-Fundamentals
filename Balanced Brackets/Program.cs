using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanced_Brackets
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			Stack<char> bracketsStack = new Stack<char>();

			for (int i = 0; i < n; i++)
			{
				string line = Console.ReadLine();

				foreach (char symbol in line)
				{
					if (symbol == '(')
					{
						bracketsStack.Push(symbol);
					}
					else if (symbol == ')')
					{
						if (bracketsStack.Count == 0 || bracketsStack.Peek() != '(')
						{
							Console.WriteLine("UNBALANCED");
							return;
						}

						bracketsStack.Pop();
					}
				}
			}

			if (bracketsStack.Count == 0)
			{
				Console.WriteLine("BALANCED");
			}
			else
			{
				Console.WriteLine("UNBALANCED");
			}
		}
	}
}