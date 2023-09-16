using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Rectangle_Area
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double width = double.Parse(Console.ReadLine());
			double height = double.Parse(Console.ReadLine());
			double area = RectangleArea(width, height);
            Console.WriteLine(area);
        }

		static double RectangleArea(double width, double height)
		{
			return width * height;
		}
	}
}