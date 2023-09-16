using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Catalog2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Vehicle> vehicles = new List<Vehicle>();
			int carHorsepowerSum = 0;
			int carCount = 0;
			int truckHorsepowerSum = 0;
			int truckCount = 0;

			while (true)
			{
				string input = Console.ReadLine();
				if (input == "End")
				{
					break;
				}

				string[] vehicleInfo = input.Split();
				string type = vehicleInfo[0];
				string model = vehicleInfo[1];
				string color = vehicleInfo[2];
				int horsepower = int.Parse(vehicleInfo[3]);

				Vehicle vehicle = new Vehicle(type, model, color, horsepower);
				vehicles.Add(vehicle);

				if (type == "car")
				{
					carHorsepowerSum += horsepower;
					carCount++;
				}
				else if (type == "truck")
				{
					truckHorsepowerSum += horsepower;
					truckCount++;
				}
			}

			while (true)
			{
				string command = Console.ReadLine();
				if (command == "Close the Catalogue")
				{
					break;
				}

				string model = command;

				Vehicle vehicle = vehicles.FirstOrDefault(v => v.Model == model);
				if (vehicle != null)
				{
					Console.WriteLine(vehicle);
				}
			}

			double averageCarHorsepower = carCount > 0 ? (double)carHorsepowerSum / carCount : 0;
			double averageTruckHorsepower = truckCount > 0 ? (double)truckHorsepowerSum / truckCount : 0;

			Console.WriteLine($"Cars have average horsepower of: {averageCarHorsepower:F2}.");
			Console.WriteLine($"Trucks have average horsepower of: {averageTruckHorsepower:F2}.");
		}
		class Vehicle
		{
			public string Type { get; set; }
			public string Model { get; set; }
			public string Color { get; set; }
			public int Horsepower { get; set; }

			public Vehicle(string type, string model, string color, int horsepower)
			{
				Type = type;
				Model = model;
				Color = color;
				Horsepower = horsepower;
			}

			public override string ToString()
			{
				return $"Type: {Type}\nModel: {Model}\nColor: {Color}\nHorsepower: {Horsepower}";
			}
		}

	}
}