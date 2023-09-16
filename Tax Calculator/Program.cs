using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax_Calculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string vehicles = Console.ReadLine();

			string[] vehicleList = vehicles.Split(new string[] { ">>" }, StringSplitOptions.RemoveEmptyEntries);
			decimal totalTaxCollected = 0;

			for (int i = 0; i < vehicleList.Length; i++)
			{
				string[] vehicleData = vehicleList[i].Split(' ');

				if (vehicleData.Length != 3)
				{
					Console.WriteLine("Invalid vehicle data format.");
					continue;
				}

				string carType = vehicleData[0];
				int yearsInUse = int.Parse(vehicleData[1]);
				int kilometersTraveled = int.Parse(vehicleData[2]);

				decimal initialTax = 0;
				decimal taxRatePerYear = 0;
				decimal taxRatePerKilometer = 0;

				switch (carType)
				{
					case "family":
						initialTax = 50;
						taxRatePerYear = 5;
						taxRatePerKilometer = 12;
						break;
					case "heavyDuty":
						initialTax = 80;
						taxRatePerYear = 8;
						taxRatePerKilometer = 14;
						break;
					case "sports":
						initialTax = 100;
						taxRatePerYear = 9;
						taxRatePerKilometer = 18;
						break;
					default:
						Console.WriteLine("Invalid car type.");
						continue;
				}

				decimal tax = initialTax - (taxRatePerYear * yearsInUse) + (taxRatePerKilometer * (kilometersTraveled / GetKilometerInterval(carType)));
				totalTaxCollected += tax;

				Console.WriteLine($"A {carType} car will pay {tax:F2} euros in taxes.");
			}

			Console.WriteLine($"The National Revenue Agency will collect {totalTaxCollected:F2} euros in taxes.");
		}
		static int GetKilometerInterval(string carType)
		{
			switch (carType)
			{
				case "family":
					return 3000;
				case "heavyDuty":
					return 9000;
				case "sports":
					return 2000;
				default:
					return 0;
			}
		}
	}
}