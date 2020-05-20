using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1812767_LESYHUNG_Lab4_
{
	class Program
	{
		class SoPhuc
		{
			int thuc, ao;
			public void nhap()
			{
				while (true)
				{
					Console.Write("Nhap vao phan thuc : ");
					thuc = int.Parse(Console.ReadLine());
					if (thuc < 0)
						Console.WriteLine("Phan thuc >=0. Vui long nhap lai !");
					else
						break;
				}
				while (true)
				{
					Console.Write("Nhap vao phan ao   : ");
					ao = int.Parse(Console.ReadLine());
					if (ao < 0)
						Console.WriteLine("Phan ao >=0. Vui long nhap lai !");
					else
						break;
				}
			}
			public void xuat()
			{
				Console.WriteLine("So phuc vua nhap la : {0} + {1}i", thuc, ao);
			}
			public static SoPhuc operator +(SoPhuc a, SoPhuc b)
			{
				SoPhuc sp = new SoPhuc();
				sp.thuc = a.thuc + b.thuc;
				sp.ao = a.ao + b.ao;
				return sp;
			}
			public static SoPhuc operator -(SoPhuc a, SoPhuc b)
			{
				SoPhuc sp = new SoPhuc();
				sp.thuc = a.thuc - b.thuc;
				sp.ao = a.ao - b.ao;
				return sp;
			}
			public static SoPhuc operator *(SoPhuc a, SoPhuc b)
			{
				SoPhuc sp = new SoPhuc();
				sp.thuc = (a.thuc * b.thuc) - (a.ao * b.ao);
				sp.ao = (a.thuc * b.ao) + (a.ao * b.thuc);
				return sp;
			}
			public static SoPhuc operator /(SoPhuc a, SoPhuc b)
			{
				SoPhuc sp = new SoPhuc();
				sp.thuc = a.thuc / b.thuc;
				sp.ao = a.ao / b.ao;
				return sp;
			}
		}
		static void Main(string[] args)
		{
			SoPhuc sp1 = new SoPhuc();
			SoPhuc sp2 = new SoPhuc();
			SoPhuc sp3 = new SoPhuc();
			Console.WriteLine("=======VUI LONG NHAP VAO CAC SO PHUC=======");
			Console.WriteLine("");
			Console.WriteLine("-So phuc thu nhat");
			Console.WriteLine("");
			sp1.nhap();
			sp1.xuat();
			Console.WriteLine("");
			Console.WriteLine("==================");
			Console.WriteLine("");
			Console.WriteLine("-So phuc thu hai");
			Console.WriteLine("");
			sp2.nhap();
			sp2.xuat();
			Console.WriteLine("==================");
			Console.WriteLine("Tong cua 2 so phuc la : ");
			sp3 = sp1 + sp2;
			sp3.xuat();
			Console.WriteLine("==================");
			Console.WriteLine("Hieu cua 2 so phuc la : ");
			sp3 = sp1 - sp2;
			sp3.xuat();
			Console.WriteLine("==================");
			Console.WriteLine("Tich cua 2 so phuc la : ");
			sp3 = sp1 * sp2;
			sp3.xuat();
			Console.WriteLine("==================");
			Console.WriteLine("Thuong cua 2 so phuc la : ");
			sp3 = sp1 / sp2;
			sp3.xuat();
			Console.ReadLine();
		}
	}
}