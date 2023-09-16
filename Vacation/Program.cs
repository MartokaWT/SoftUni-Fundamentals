using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int countOfPeople = int.Parse(Console.ReadLine());
			string groupType = Console.ReadLine();
			string dayOfWeek = Console.ReadLine();
			double pricePerPerson = 0;

			switch (groupType)
			{
				case "Students":
					if (dayOfWeek == "Friday")
						pricePerPerson = 8.45;
					else if (dayOfWeek == "Saturday")
						pricePerPerson = 9.80;
					else if (dayOfWeek == "Sunday")
						pricePerPerson = 10.46;

					if (countOfPeople >= 30)
						pricePerPerson *= 0.85;
					break;

				case "Business":
					if (dayOfWeek == "Friday")
						pricePerPerson = 10.90;
					else if (dayOfWeek == "Saturday")
						pricePerPerson = 15.60;
					else if (dayOfWeek == "Sunday")
						pricePerPerson = 16.00;

					if (countOfPeople >= 100)
					{
						countOfPeople -= 10;
					}
					break;

				case "Regular":
					if (dayOfWeek == "Friday")
						pricePerPerson = 15.00;
					else if (dayOfWeek == "Saturday")
						pricePerPerson = 20.00;
					else if (dayOfWeek == "Sunday")
						pricePerPerson = 22.50;

					if (countOfPeople >= 10 && countOfPeople <= 20)
						pricePerPerson *= 0.95;
					break;

				default:
					Console.WriteLine("Invalid group type.");
					return;
			}

			double totalPrice = countOfPeople * pricePerPerson;
			Console.WriteLine($"Total price: {totalPrice:F2}");
		}
	}
}