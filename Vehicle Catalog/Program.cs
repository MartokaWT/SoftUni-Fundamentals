using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Catalog
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Catalog catalog = new Catalog();

			string input;
			while ((input = Console.ReadLine()) != "end")
			{
				string[] data = input.Split('/');
				string type = data[0];
				string brand = data[1];
				string model = data[2];

				if (type == "Truck")
				{
					int weight = int.Parse(data[3]);
					Truck truck = new Truck(brand, model, weight);
					catalog.Trucks.Add(truck);
				}
				else if (type == "Car")
				{
					int horsePower = int.Parse(data[3]);
					Car car = new Car(brand, model, horsePower);
					catalog.Cars.Add(car);
				}
			}

			List<Car> orderedCars = catalog.Cars.OrderBy(car => car.Brand).ToList();
			List<Truck> orderedTrucks = catalog.Trucks.OrderBy(truck => truck.Brand).ToList();

			Console.WriteLine("Cars:");
			foreach (var car in orderedCars)
			{
				Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
			}

			Console.WriteLine("Trucks:");
			foreach (var truck in orderedTrucks)
			{
				Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
			}
		}

		class Truck
		{
			public string Brand { get; set; }
			public string Model { get; set; }
			public int Weight { get; set; }

			public Truck(string brand, string model, int weight)
			{
				Brand = brand;
				Model = model;
				Weight = weight;
			}
		}

		class Car
		{
			public string Brand { get; set; }
			public string Model { get; set; }
			public int HorsePower { get; set; }

			public Car(string brand, string model, int horsePower)
			{
				Brand = brand;
				Model = model;
				HorsePower = horsePower;
			}
		}

		class Catalog
		{
			public List<Truck> Trucks { get; }
			public List<Car> Cars { get; }

			public Catalog()
			{
				Trucks = new List<Truck>();
				Cars = new List<Car>();
			}
		}
	}
}