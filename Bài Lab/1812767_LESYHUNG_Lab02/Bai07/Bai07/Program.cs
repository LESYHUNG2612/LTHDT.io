using System;

namespace Bai07
{

	class PhanSo
	{
		private float ts;
		private float ms;

		public float TuSo
		{
			get { return ts; }
			set { ts = value; }
		}
		public float MauSo
		{
			get { return ms; }
			set { ms = value; }
		}
		public static PhanSo operator +(PhanSo a, PhanSo b)
		{
			PhanSo Tong = new PhanSo();
			Tong.MauSo = a.MauSo * b.MauSo;
			Tong.TuSo = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
			return Tong;
		}
		public static PhanSo operator -(PhanSo a, PhanSo b)
		{
			PhanSo Hieu = new PhanSo();
			Hieu.MauSo = a.MauSo * b.MauSo;
			Hieu.TuSo = a.TuSo * b.MauSo - b.TuSo * a.MauSo;
			return Hieu;
		}

		public static PhanSo operator *(PhanSo a, PhanSo b)
		{
			PhanSo Tong = new PhanSo();
			Tong.MauSo = a.MauSo * b.MauSo;
			Tong.TuSo = a.TuSo * b.TuSo;
			return Tong;
		}
		public static PhanSo operator /(PhanSo a, PhanSo b)
		{
			PhanSo Thuong = new PhanSo();
			Thuong.MauSo = a.MauSo * b.TuSo;
			Thuong.TuSo = a.TuSo * b.MauSo;
			return Thuong;
		}
		public void SoSanhVoi(PhanSo a)
		{
			float x, y;
			if (MauSo == a.MauSo)
			{
				x = TuSo;
				y = a.TuSo;
			}
			else
			{
				x = TuSo * a.MauSo;
				y = MauSo * a.TuSo;
			}
			if (x < y) Console.Write("<");
			if (x > y) Console.Write(">");
			if (x == y) Console.Write("=");
		}
		public void Nhap()
		{
			Console.Write("Nhap tu so: ");
			ts = Convert.ToInt32(Console.ReadLine());

			while (true)
			{
				Console.Write("Nhap mau so: ");
				ms = Convert.ToInt32(Console.ReadLine());
				if (ms == 0)
				{
					Console.WriteLine("Mau so khong duoc = 0!");
				}
				else
				{
					break;
				}
			}
		}

		public float uscln(float a, float b)
		{
			a = Math.Abs(ts);
			b = Math.Abs(ms);
			while (a != b && b != 0 && a != 0)
			{
				if (a > b)
					a = a - b;
				if (a < b)
					b = b - a;
			}
			return a;
		}
		public PhanSo RutGon()
		{
			PhanSo a = new PhanSo();
			float u = uscln(ts, ms);
			if (u != 0)
			{
				a.ts = ts / u;
				a.ms = ms / u;
			}
			else
			{
				a.ts = ts;
				a.ms = ms;
			}
			return a;
		}
		public void Xuat()
		{
			Console.WriteLine($"{ts}/{ms}");
		}
		public void Xuat0Ln()
		{
			Console.Write($"{ts}/{ms}");
		}


	}
	class Program
	{
		static void Main(string[] args)
		{
			PhanSo a = new PhanSo();
			PhanSo b = new PhanSo();
			PhanSo temp = new PhanSo();

			Console.WriteLine("Vui long nhap tu va mau cua phan so a: ");
			a.Nhap();
			Console.WriteLine("Vui long nhap tu va mau cua phan so b: ");
			b.Nhap();

			Console.WriteLine($"2 phan so vua nhap la:");
			a.Xuat(); b.Xuat();

			Console.WriteLine("cac toan tu doi voi 2 phan so: ");
			Console.Write($"({a.TuSo}/{a.MauSo})+({b.TuSo}/{b.MauSo})= ");
			temp = a + b;
			temp = temp.RutGon();
			temp.Xuat();
			Console.Write($"({a.TuSo}/{a.MauSo})-({b.TuSo}/{b.MauSo})= ");
			temp = a - b;
			temp = temp.RutGon();
			temp.Xuat();
			Console.Write($"({a.TuSo}/{a.MauSo})*({b.TuSo}/{b.MauSo})= ");
			temp = a * b;
			temp = temp.RutGon();
			temp.Xuat();
			Console.Write($"({a.TuSo}/{a.MauSo})/({b.TuSo}/{b.MauSo})= ");
			temp = a / b;
			temp = temp.RutGon();
			temp.Xuat();


			Console.WriteLine("so sanh 2 phan so: ");
			a.Xuat0Ln(); a.SoSanhVoi(b); b.Xuat();
		}
	}
}
