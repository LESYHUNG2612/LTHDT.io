using System;

using System;

namespace Bai04
{
	class Program
	{


		public static int a, b;
		public static void nhap()
		{
			Console.WriteLine("nhap so thu nhat = ");
			a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("nhap so thu hai = ");
			b = Convert.ToInt32(Console.ReadLine());
		}
		static void swap()
		{
			int t = a;
			a = b;
			b = t;
			Console.WriteLine("trong phuong thuc swap: a = {0} ,b ={1}", a, b);
		}

		static void Main(string[] args)
		{
			nhap();
			Console.WriteLine("truoc phuong thuc swap: a ={0} , b={1}", a, b);
			swap();
			Console.WriteLine("sau phuong thuc swap: a ={0} , b={1}", a, b);
			Console.ReadLine();
		}

	}
}
