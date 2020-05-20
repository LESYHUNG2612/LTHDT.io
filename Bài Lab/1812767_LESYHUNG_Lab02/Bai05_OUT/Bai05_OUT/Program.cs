using System;

namespace Bai05_OUT
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
			public void gettime(out int h, out int m, out int s)
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
			int thehour;
			int theminute;
			int thesecond;
			t.gettime(out thehour, out theminute, out thesecond);
			Console.WriteLine("current time : {0}:{1}:{2}", thehour, theminute, thesecond);
			Console.ReadLine();
		}

	}
}
