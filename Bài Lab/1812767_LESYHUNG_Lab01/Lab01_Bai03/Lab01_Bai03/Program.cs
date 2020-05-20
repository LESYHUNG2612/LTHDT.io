using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Bai03
{
	class Hinhchunhat
	{
		public int Chieudai;
		public int Chieurong;
		public void setHCN(int Cd,int Cr)
		{ 
			Chieudai = Cd;
			Chieurong = Cr;
		}
		public int Chuvi()
		{
			return (Chieudai+Chieurong)*2;
		}
		public int Dientich()
		{
			return Chieudai*Chieurong;
		}
		static void Main(string[] args)
		{
			int Cd, Cr;
			Console.WriteLine("Nhap chieu dai vao: ");
			Cd = int.Parse(Console.ReadLine());

			Console.WriteLine("Nhap chieu rong vao: ");
			Cr = int.Parse(Console.ReadLine());

			Hinhchunhat Dt = new Hinhchunhat();
			Dt.setHCN(Cd, Cr);
			Hinhchunhat Cv = new Hinhchunhat();
			Cv.setHCN(Cd, Cr);

			Console.WriteLine("Chu vi hinh chu nhat la : {0}", Cv.Chuvi());
			Console.WriteLine("Dien tich hinh chu nhat la : {0}", Dt.Dientich());
			Console.ReadLine();
			return;
		}
	}
}
