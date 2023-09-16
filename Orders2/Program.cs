using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var products = new Dictionary<string, (double price, int quantity)>();

			while (true)
			{
				string input = Console.ReadLine();

				if (input == "buy")
					break;

				string[] data = input.Split(' ');

				string name = data[0];
				double price = double.Parse(data[1]);
				int quantity = int.Parse(data[2]);

				if (products.ContainsKey(name))
				{
					products[name] = (price, products[name].quantity + quantity);
				}
				else
				{
					products[name] = (price, quantity);
				}
			}

			foreach (var pair in products)
			{
				string name = pair.Key;
				double totalPrice = pair.Value.price * pair.Value.quantity;
				Console.WriteLine($"{name} -> {totalPrice:F2}");
			}
		}
	}
}