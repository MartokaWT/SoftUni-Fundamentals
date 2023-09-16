using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			double totalPrice = 0;

			for (int i = 0; i < n; i++)
			{
				double pricePerCapsule = double.Parse(Console.ReadLine());
				int days = int.Parse(Console.ReadLine());
				int capsulesCount = int.Parse(Console.ReadLine());

				double orderPrice = (days * capsulesCount * pricePerCapsule);
				Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");
				totalPrice += orderPrice;
			}

			Console.WriteLine($"Total: ${totalPrice:F2}");
		}
	}
}