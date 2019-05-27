using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab2_1
{
	class Program
	{
		static void Main(string[] args)
		{

			double g = 9.8;
			Console.WriteLine("Enter m");
			int m = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter h");
			int h = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter v");
			int v = int.Parse(Console.ReadLine());
			Console.WriteLine("E = " + (m * v * v) / 2);
			Console.WriteLine("P = " + (m * g * h));
			Console.ReadKey();
		}
	}
}

