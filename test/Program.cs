using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace test
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int a = 5;
			int b = a++;
			int c = ++a;
			Console.WriteLine(c);
		}
	}
}