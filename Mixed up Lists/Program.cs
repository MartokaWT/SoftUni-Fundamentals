using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mixed_up_Lists
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> firstInput = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToList();
			List<int> secondInput = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToList();
			List<int> rule = new List<int>();
			List<int> maxList = new List<int>();
			List<int> mixedList = new List<int>();
			if (firstInput.Count > secondInput.Count)
			{
				maxList = firstInput;
			}
			else
			{
				maxList = secondInput;
				maxList.Reverse();
			}
			for (int i = maxList.Count - 2; i < maxList.Count; i++)
			{
				rule.Add(maxList[i]);
			}
			rule.Sort();
			if (firstInput.Count > secondInput.Count)
			{
				firstInput.RemoveRange(firstInput.Count - 2, 2);
				secondInput.Reverse();
			}
			else
			{
				secondInput.RemoveRange(secondInput.Count - 2, 2);
				secondInput.Reverse();
			}
			for (int i = 0; i < firstInput.Count; i++)
			{
				mixedList.Add(firstInput[i]);
				mixedList.Add(secondInput[i]);
			}
			List<int> output = mixedList.FindAll(x => x > rule[0] && x < rule[1]);
			output.Sort();
			Console.WriteLine(string.Join(" ", output));
		}
	}
}