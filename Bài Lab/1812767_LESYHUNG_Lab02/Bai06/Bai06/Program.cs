using System;

namespace Bai06
{
	class Program
	{
		public class phanso
		{
			public int ts, ms, n;
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
			public phanso cong(phanso a)
			{
				phanso b = new phanso();
				b.ts = ts * a.ms + ms * a.ts;
				b.ms = ms * a.ms;
				return b;
			}
			public phanso tru(phanso a)
			{
				phanso b = new phanso();
				b.ts = ts * a.ms - ms * a.ts;
				b.ms = ms * a.ms;

				return b;
			}
			public phanso nhan(phanso a)
			{
				phanso b = new phanso();
				b.ts = ts * a.ts;
				b.ms = ms * a.ms;
				return b;
			}
			public phanso chia(phanso a)
			{
				phanso b = new phanso();
				b.ts = ts * a.ms;
				b.ms = ms * a.ts;
				return b;
			}
			public void xuat()
			{
				Console.WriteLine("ket qua la phan so :{0}/{1} ", ts, ms);
			}
		}
		static void Main(string[] args)
		{
			phanso a = new phanso();
			a.nhap();
			a.xuat();
			phanso b = new phanso();
			b.nhap();
			b.xuat();
			phanso c = new phanso();
			c = a.cong(b);
			Console.WriteLine($"tong 2 phan so la :{c.ts}/{c.ms} ");
			c = a.tru(b);
			Console.WriteLine($"hieu 2 phan so la :{c.ts}/{c.ms} ");
			c = a.nhan(b);
			Console.WriteLine($"tich 2 phan so la :{c.ts}/{c.ms} ");
			c = a.chia(b);
			Console.WriteLine($"thuong 2 phan so la :{c.ts}/{c.ms} ");

			Console.ReadLine();
		}
	}
}

