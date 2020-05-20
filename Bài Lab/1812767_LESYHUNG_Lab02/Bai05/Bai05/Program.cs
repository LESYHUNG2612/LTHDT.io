using System;

namespace Bai05
{
	class Program
	{
		public class time
		{
			int hour;
			int minute;
			int second;
			public void display()
			{
				Console.WriteLine("{0}:{1}:{2}", hour, minute, second);

			}
			public void gettime(ref int h, ref int m, ref int s)
			{
				h = hour;
				m = minute;
				s = second;
			}
			public time(System.DateTime dt)
			{
				hour = dt.Hour;
				minute = dt.Minute;
				second = dt.Second;
			}
		}

		static void Main(string[] args)
		{
			DateTime currenttime = DateTime.Now;
			time t = new time(currenttime);
			t.display();
			int thehour = 0;
			int theminute = 0;
			int thesecond = 0;
			t.gettime(ref thehour, ref theminute, ref thesecond);
			Console.WriteLine("current time : {0}:{1}:{2}", thehour, theminute, thesecond);
			Console.ReadLine();
		}

	}
}
