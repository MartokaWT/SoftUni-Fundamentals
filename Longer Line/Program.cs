using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longer_Line
{
	public class Point
	{
		public int X { get; set; }
		public int Y { get; set; }

		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}

		public double DistanceToCenter()
		{
			return Math.Sqrt(X * X + Y * Y);
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			int X1, Y1, X2, Y2, X3, Y3, X4, Y4;

			X1 = int.Parse(Console.ReadLine());
			Y1 = int.Parse(Console.ReadLine());
			X2 = int.Parse(Console.ReadLine());
			Y2 = int.Parse(Console.ReadLine());
			X3 = int.Parse(Console.ReadLine());
			Y3 = int.Parse(Console.ReadLine());
			X4 = int.Parse(Console.ReadLine());
			Y4 = int.Parse(Console.ReadLine());

			Point line1Point1 = new Point(X1, Y1);
			Point line1Point2 = new Point(X2, Y2);
			Point line2Point1 = new Point(X3, Y3);
			Point line2Point2 = new Point(X4, Y4);

			double distanceLine1Point1 = line1Point1.DistanceToCenter();
			double distanceLine1Point2 = line1Point2.DistanceToCenter();
			double distanceLine2Point1 = line2Point1.DistanceToCenter();
			double distanceLine2Point2 = line2Point2.DistanceToCenter();

			double line1Length = distanceLine1Point1 + distanceLine1Point2;
			double line2Length = distanceLine2Point1 + distanceLine2Point2;

			if (line1Length >= line2Length)
			{
				Console.WriteLine("({0}, {1})({2}, {3})", X1, Y1, X2, Y2);
			}
			else
			{
				Console.WriteLine("({0}, {1})({2}, {3})", X3, Y3, X4, Y4);
			}
		}
	}
}