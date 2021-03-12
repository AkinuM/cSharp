using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTimeNow
{
	class Program
	{
		
		static void Main(string[] args)
		{
			int[] count = new int[10];

			void Counting(DateTime tempdateTime, string elementDateTime)
			{
				if (int.Parse(tempdateTime.ToString(elementDateTime)) > 9)
				{
					int temp = int.Parse(tempdateTime.ToString(elementDateTime));
					for (int i = 0; i < elementDateTime.Length; i++)
					{
						count[temp % 10]++;
						temp /= 10;
					}
				}
				else
				{
					count[0]++;
					count[int.Parse(tempdateTime.ToString(elementDateTime))]++;
				}
			}

			void output()
			{
				for (int i = 0; i < 10; i++)
				{
					if (i != 9)
					{
						Console.Write(count[i]);
						count[i] = 0;
						Console.Write(" ");
					}
					else
					{
						Console.WriteLine(count[i]);
						count[i] = 0;
					}
				}
			}

			DateTime dateTime = DateTime.Now;
			Console.WriteLine(dateTime);
			Counting(dateTime, "dd");
			Counting(dateTime, "MM");
			Counting(dateTime, "yyyy");
			Counting(dateTime, "HH");
			Counting(dateTime, "mm");
			Counting(dateTime, "ss");
			for (int i = 0; i < 10; i++)
			{
				if (i != 9)
				{
					Console.Write(i);
					Console.Write(" ");
				}
				else
				{
					Console.WriteLine(i);
				}
			}
			for (int i = 0; i < 10; i++)
			{
				if (i != 9)
				{
					Console.Write("^");
					Console.Write(" ");
				}
				else
				{
					Console.WriteLine("^");
				}
			}
			for (int i = 0; i < 10; i++)
			{
				if (i != 9)
				{
					Console.Write("|");
					Console.Write(" ");
				}
				else
				{
					Console.WriteLine("|");
				}
			}
			output();
			for (int i = 0; i < 19; i++)
			{
				if (i != 18)
				{
					Console.Write("-");
				}
				else
				{
					Console.WriteLine("-");
				}
			}
			DateTime newDateTime = DateTime.Now;
			if (int.Parse(DateTime.Now.ToString("HH")) > 11)
			{
				newDateTime.AddHours(-12);
				Console.Write(newDateTime.ToString("HH:mm:ss "));
				Console.Write("PM ");
				Console.WriteLine(newDateTime.ToString("yy.MM.dd"));
			}
			else
			{
				Console.Write(newDateTime.ToString("HH:mm:ss "));
				Console.Write("AM ");
				Console.WriteLine(newDateTime.ToString("yy.MM.dd"));
			}
			Counting(newDateTime, "dd");
			Counting(newDateTime, "MM");
			Counting(newDateTime, "yy");
			Counting(newDateTime, "HH");
			Counting(newDateTime, "mm");
			Counting(newDateTime, "ss");
			for (int i = 0; i < 10; i++)
			{
				if (i != 9)
				{
					Console.Write(i);
					Console.Write(" ");
				}
				else
				{
					Console.WriteLine(i);
				}
			}
			for (int i = 0; i < 10; i++)
			{
				if (i != 9)
				{
					Console.Write("^");
					Console.Write(" ");
				}
				else
				{
					Console.WriteLine("^");
				}
			}
			for (int i = 0; i < 10; i++)
			{
				if (i != 9)
				{
					Console.Write("|");
					Console.Write(" ");
				}
				else
				{
					Console.WriteLine("|");
				}
			}
			output();
		}
	}
}
