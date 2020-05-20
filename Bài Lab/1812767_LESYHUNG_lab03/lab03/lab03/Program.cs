using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
	class Program
	{
		public class TamThuc
		{
			private int a, b, c;
			public TamThuc()
			{
				a = b = c = 0;
			}
			public TamThuc(int a, int b, int c)
			{
				this.a = a;
				this.b = b;
				this.c = c;
			}
			public TamThuc(TamThuc ob)
			{
				a = ob.a;
				b = ob.b;
				c = ob.c;
			}
			public static TamThuc Nhap()
			{
				int a, b, c;
				bool KiemTra = false;
				Console.WriteLine("Nhap he so tam thuc a,b,c : ");
				do
				{
					Console.Write(" Nhap he so a (x^2) >> ");
					KiemTra = Int32.TryParse(Console.ReadLine(), out a);
				}
				while (!KiemTra);
				do
				{
					Console.Write("Nhap he so b (x)   >> ");
					KiemTra = Int32.TryParse(Console.ReadLine(), out b);
				}
				while (!KiemTra);
				do
				{
					Console.Write("Nhap he so c       >> ");
					KiemTra = Int32.TryParse(Console.ReadLine(), out c);
				}
				while (!KiemTra);
				return new TamThuc(a, b, c);
			}
			public void XuatTamThuc()
			{
				Console.Write("{0}x^2 + {1}x + {2}", a, b, c);
			}
			public static TamThuc operator +(TamThuc x, TamThuc y)
			{
				TamThuc tong = new TamThuc();
				tong.a = x.a + y.a;
				tong.b = x.b + y.b;
				tong.c = x.c + y.c;
				return tong;
			}
			public static TamThuc operator -(TamThuc x, TamThuc y)
			{
				TamThuc hieu = new TamThuc();
				hieu.a = x.a - y.a;
				hieu.b = x.b - y.b;
				hieu.c = x.c - y.c;
				return hieu;
			}
		}
		static void Main(string[] args)
		{
			TamThuc TT1 = new TamThuc();
			TamThuc TT2 = new TamThuc();
			TamThuc TT3 = new TamThuc();
			TamThuc TT4 = new TamThuc();
			Console.WriteLine("Tam thuc thu 1: ");
			TT1 = TamThuc.Nhap();
			Console.WriteLine("Tam thuc vua nhap la : ");
			TT1.XuatTamThuc();
			Console.WriteLine("Tam thuc thu 2; ");
			TT2 = TamThuc.Nhap();
			Console.WriteLine("Tam thuc vua nhap la : ");
			TT2.XuatTamThuc();
			TT3 = TT1 + TT2;
			Console.WriteLine("Tong cua 2 tam thuc : ");
			TT3.XuatTamThuc();
			TT4 = TT1 - TT2;
			Console.WriteLine("Hieu cua 2 tam thuc : ");
			TT4.XuatTamThuc();
			Console.ReadLine();
		}
	}
}
