using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padawan_Equipment
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double moneyJohnHas = double.Parse(Console.ReadLine());
			int studentsCount = int.Parse(Console.ReadLine());
			double lightsaberPrice = double.Parse(Console.ReadLine());
			double robePrice = double.Parse(Console.ReadLine());
			double beltPrice = double.Parse(Console.ReadLine());

			int sabersToBuy = (int)Math.Ceiling(studentsCount * 1.1);
			int freeBelts = studentsCount / 6;

			double totalCost = sabersToBuy * lightsaberPrice + studentsCount * robePrice + (studentsCount - freeBelts) * beltPrice;

			if (totalCost <= moneyJohnHas)
			{
				Console.WriteLine($"The money is enough - it would cost {totalCost:F2}lv.");
			}
			else
			{
				double neededMoney = totalCost - moneyJohnHas;
				Console.WriteLine($"John will need {neededMoney:F2}lv more.");
			}
		}
	}
}