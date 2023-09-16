using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decrypting_Commands
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string message = Console.ReadLine();

			while (true)
			{
				string command = Console.ReadLine();

				if (command == "Finish")
				{
					break;
				}

				string[] tokens = command.Split();

				string action = tokens[0];

				switch (action)
				{
					case "Replace":
						string currentStr = tokens[1];
						string newStr = tokens[2];
						message = message.Replace(currentStr, newStr);
						Console.WriteLine(message);
						break;

					case "Cut":
						int startIndex = int.Parse(tokens[1]);
						int endIndex = int.Parse(tokens[2]);
						if (IsIndexValid(startIndex, message.Length) && IsIndexValid(endIndex, message.Length))
						{
							if (startIndex <= endIndex)
							{
								message = message.Remove(startIndex, endIndex - startIndex + 1);
								Console.WriteLine(message);
							}
							else
							{
								Console.WriteLine("Invalid indices!");
							}
						}
						else
						{
							Console.WriteLine("Invalid indices!");
						}
						break;

					case "Make":
						string makeAction = tokens[1];
						if (makeAction == "Upper")
						{
							message = message.ToUpper();
						}
						else if (makeAction == "Lower")
						{
							message = message.ToLower();
						}
						Console.WriteLine(message);
						break;

					case "Check":
						string searchString = tokens[1];
						if (message.Contains(searchString))
						{
							Console.WriteLine($"Message contains {searchString}");
						}
						else
						{
							Console.WriteLine($"Message doesn't contain {searchString}");
						}
						break;

					case "Sum":
						int sumStartIndex = int.Parse(tokens[1]);
						int sumEndIndex = int.Parse(tokens[2]);
						if (IsIndexValid(sumStartIndex, message.Length) && IsIndexValid(sumEndIndex, message.Length))
						{
							if (sumStartIndex <= sumEndIndex)
							{
								int sum = 0;
								for (int i = sumStartIndex; i <= sumEndIndex; i++)
								{
									sum += message[i];
								}
								Console.WriteLine(sum);
							}
							else
							{
								Console.WriteLine("Invalid indices!");
							}
						}
						else
						{
							Console.WriteLine("Invalid indices!");
						}
						break;
				}
			}
		}

		static bool IsIndexValid(int index, int length)
		{
			return index >= 0 && index < length;
		}
	}
}