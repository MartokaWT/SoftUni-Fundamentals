using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Boxes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Box> boxes = new List<Box>();

			string input;
			while ((input = Console.ReadLine()) != "end")
			{
				string[] data = input.Split();
				string serialNumber = data[0];
				string itemName = data[1];
				int itemQuantity = int.Parse(data[2]);
				decimal itemPrice = decimal.Parse(data[3]);

				Item item = new Item
				{
					Name = itemName,
					Price = itemPrice
				};

				decimal boxPrice = itemQuantity * itemPrice;

				Box box = new Box
				{
					SerialNumber = serialNumber,
					Item = item,
					ItemQuantity = itemQuantity,
					BoxPrice = boxPrice
				};

				boxes.Add(box);
			}

			List<Box> orderedBoxes = boxes.OrderByDescending(box => box.BoxPrice).ToList();

			foreach (var box in orderedBoxes)
			{
				Console.WriteLine(box.SerialNumber);
				Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
				Console.WriteLine($"-- ${box.BoxPrice:F2}");
			}
		}
		class Item
		{
			public string Name { get; set; }
			public decimal Price { get; set; }
		}

		class Box
		{
			public string SerialNumber { get; set; }
			public Item Item { get; set; }
			public int ItemQuantity { get; set; }
			public decimal BoxPrice { get; set; }
		}
	}
}