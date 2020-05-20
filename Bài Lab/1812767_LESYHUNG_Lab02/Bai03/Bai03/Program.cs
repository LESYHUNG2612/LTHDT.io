using System;

namespace Bai03
{
	class Program
	{
		static class tienich
		{
			public static int n1, n2;
			public static long luythua()
			{
				int coso = n1;
				int somu = n2;
				long kq = 1;
				for (int i = 0; i < somu; i++)
				{
					kq *= coso;
				}
				return kq;
			}
			public static int uscln()
			{
				int a = n1;
				int b = n2;
				a = Math.Abs(a);
				b = Math.Abs(b);
				while (a != b)
				{
					if (a > b)
						a = a - b;
					if (a < b)
						b = b - a;
				}
				return a;
			}
			public static void nhap()
			{
				Console.WriteLine("nhap vao so thu nhat = ");
				n1 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("nhap vao so thu hai = ");
				n2 = Convert.ToInt32(Console.ReadLine());
			}
			public static int bscnn()
			{
				int a = n1;
				int b = n2;
				return (a * b) / uscln();
			}
		}
		static void Main(string[] args)
		{
			tienich.nhap();
			Console.WriteLine("luy thua = {0}", tienich.luythua());
			Console.WriteLine("uoc chung lon nhat = {0}", tienich.uscln());
			Console.WriteLine("boi chung nho nhat = {0}", tienich.bscnn());
			Console.ReadLine();
		}
	}
}
