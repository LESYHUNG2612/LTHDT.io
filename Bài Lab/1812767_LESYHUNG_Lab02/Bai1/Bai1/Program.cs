using System;

namespace Bai1

{
	class Program
	{
		public class phanso
		{
			public int ts;
			public int ms;
			public phanso()
			{
				ts = 0;
				ms = 1;
			}
			public void nhap()
			{
				Console.WriteLine("nhap vao tu so : ");
				ts = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("nhap vao mau so : ");
				ms = Convert.ToInt32(Console.ReadLine());
			}

			public phanso(phanso a)
			{
				ts = a.ts;
				ms = a.ms;
			}
			public void show()
			{
				Console.WriteLine("phan so {0}/{1}", ts, ms);
			}
		}
		static void Main(string[] args)
		{
			phanso a = new phanso();
			a.nhap();
			a.show();
			phanso b = new phanso(a);
			b.show();
			Console.ReadLine();
		}
	}
}
