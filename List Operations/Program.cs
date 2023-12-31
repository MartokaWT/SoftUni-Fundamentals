﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Operations
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine()
			.Split(' ', StringSplitOptions.RemoveEmptyEntries)
			.Select(int.Parse)
			.ToList();

			string input;
			while ((input = Console.ReadLine()) != "End")
			{
				string[] command = input.Split();

				switch (command[0])
				{
					case "Add":
						int numberToAdd = int.Parse(command[1]);
						numbers.Add(numberToAdd);
						break;

					case "Insert":
						int numberToInsert = int.Parse(command[1]);
						int index = int.Parse(command[2]);

						if (index >= 0 && index < numbers.Count)
						{
							numbers.Insert(index, numberToInsert);
						}
						else
						{
							Console.WriteLine("Invalid index");
						}
						break;

					case "Remove":
						int indexToRemove = int.Parse(command[1]);

						if (indexToRemove >= 0 && indexToRemove < numbers.Count)
						{
							numbers.RemoveAt(indexToRemove);
						}
						else
						{
							Console.WriteLine("Invalid index");
						}
						break;

					case "Shift":
						int count = int.Parse(command[2]);

						if (command[1] == "left")
						{
							for (int i = 0; i < count % numbers.Count; i++)
							{
								int firstNumber = numbers[0];
								numbers.RemoveAt(0);
								numbers.Add(firstNumber);
							}
						}
						else if (command[1] == "right")
						{
							for (int i = 0; i < count % numbers.Count; i++)
							{
								int lastNumber = numbers[numbers.Count - 1];
								numbers.RemoveAt(numbers.Count - 1);
								numbers.Insert(0, lastNumber);
							}
						}
						break;

					default:
						Console.WriteLine("Invalid command");
						break;
				}
			}

			Console.WriteLine(string.Join(" ", numbers));
		}
	}
}