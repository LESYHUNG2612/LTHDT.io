// khai bao su dung cac dinh danh trong namespae
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
	class Program
	{
		// lop mac dinh chuong trinh dat ra
		class myclass
		{
			// lop doi tuong nguoi su dung dinh nghia
			int a;
			public void set_a(int num)
			{
				a = num;
			}
			public int get_a()
			{
				return a;
			}

		}
		static void Main(string[] args)
		{
			// khai bao cac doi tuong moi
			myclass ob1 = new myclass();
			myclass ob2 = new myclass();

			ob1.set_a(10);
			ob2.set_a(99);

			Console.WriteLine("gia tri a cua ob1: {0}", ob1.get_a());
			Console.WriteLine("gia tri a cua ob12: {0}", ob2.get_a());
			Console.ReadLine();
		}
	}
}
