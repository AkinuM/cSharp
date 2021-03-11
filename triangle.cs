using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
	class Program
	{
		static void Main(string[] args)
		{
			double firstEdge, secondEdge, thirdEdge, firstAngle, secondAngle, thirdAngle, height, perimeter, halfPerimeter, area, radiusСircumscribedСircle, radiusInscribedСircle;

			void Perimeter()
			{
				perimeter = firstEdge + secondEdge + thirdEdge;
			}

			void HalfPerimeter()
			{
				halfPerimeter = perimeter / 2;
			}

			void Area()
			{
				area = Math.Sqrt(halfPerimeter * Math.Sqrt(halfPerimeter - firstEdge) * Math.Sqrt(halfPerimeter - secondEdge) * Math.Sqrt(halfPerimeter - thirdEdge));
			}

			void FirstAngle()
			{
				firstAngle = Math.Acos((Math.Pow(secondEdge, 2) + Math.Pow(thirdEdge, 2) - Math.Pow(firstEdge, 2)) / 2 / secondEdge / thirdEdge) * 180 / 3.1415;
			}

			void SecondAngle()
			{
				secondAngle = Math.Acos((Math.Pow(firstEdge, 2) + Math.Pow(thirdEdge, 2) - Math.Pow(secondEdge, 2)) / 2 / firstEdge / thirdEdge) * 180 / 3.1415;
			}

			void ThirdAngle()
			{
				thirdAngle = Math.Acos((Math.Pow(secondEdge, 2) + Math.Pow(firstEdge, 2) - Math.Pow(thirdEdge, 2)) / 2 / secondEdge / firstEdge) * 180 / 3.1415;
			}

			void RadiusСircumscribedСircle()
			{
				radiusСircumscribedСircle = firstEdge * secondEdge * thirdEdge / 4 / area;
			}

			void RadiusInscribedСircle()
			{
				radiusInscribedСircle = area / halfPerimeter;
			}

			void getInfo()
			{
				Console.Write("Периметр треугольника: ");
				Console.WriteLine("{0:0.##}", perimeter);
				Console.Write("Площадь треугольника: ");
				Console.WriteLine("{0:0.##}", area);
				Console.Write("Радиус описанной окружности: ");
				Console.WriteLine("{0:0.##}", radiusСircumscribedСircle);
				Console.Write("Радиус вписанной окружности: ");
				Console.WriteLine("{0:0.##}", radiusInscribedСircle);
			}

			Console.Write("Варианты ввода:\n1. Три стороны\n2. Сторона и два угла\n3. Две стороны и угол\n\nВыберите пункт: ");
			int choice = Convert.ToInt32(Console.ReadLine());
			switch (choice)
			{
				case 1:
					Console.Clear();
					Console.Write("Введите первую сторону: ");
					firstEdge = Convert.ToDouble(Console.ReadLine());
					Console.Clear();
					Console.Write("Введите вторую сторону: ");
					secondEdge = Convert.ToDouble(Console.ReadLine());
					Console.Clear();
					Console.Write("Введите третью сторону: ");
					thirdEdge = Convert.ToDouble(Console.ReadLine());
					Perimeter();
					HalfPerimeter();
					Area();
					FirstAngle();
					SecondAngle();
					ThirdAngle();
					RadiusСircumscribedСircle();
					RadiusInscribedСircle();
					Console.Clear();
					Console.Write("Первый угол треугольника: ");
					Console.WriteLine("{0:0.##}", firstAngle);
					Console.Write("Второй угол треугольника: ");
					Console.WriteLine("{0:0.##}", secondAngle);
					Console.Write("Третий угол треугольника: ");
					Console.WriteLine("{0:0.##}", thirdAngle);
					getInfo();
					break;
				case 2:
					Console.Clear();
					Console.Write("Введите сторону: ");
					firstEdge = Convert.ToDouble(Console.ReadLine());
					Console.Clear();
					Console.Write("Введите первый угол: ");
					firstAngle = Convert.ToDouble(Console.ReadLine());
					Console.Clear();
					Console.Write("Введите второй угол: ");
					secondAngle = Convert.ToDouble(Console.ReadLine());
					thirdAngle = 180 - firstAngle - secondAngle;
					secondEdge = firstEdge * Math.Sin(secondAngle * 3.1415 / 180) / Math.Sin(thirdAngle * 3.1415 / 180);
					thirdEdge = firstEdge * Math.Sin(firstAngle * 3.1415 / 180) / Math.Sin(thirdAngle * 3.1415 / 180);
					Perimeter();
					HalfPerimeter();
					Area();
					RadiusСircumscribedСircle();
					RadiusInscribedСircle();
					Console.Clear();
					Console.Write("Третий угол треугольника: ");
					Console.WriteLine("{0:0.##}", thirdAngle);
					Console.Write("Вторая сторона треугольника: ");
					Console.WriteLine("{0:0.##}", secondEdge);
					Console.Write("Третья сторона треугольника: ");
					Console.WriteLine("{0:0.##}", thirdEdge);
					getInfo();
					break;
				case 3:
					Console.Clear();
					Console.Write("Введите первую сторону: ");
					firstEdge = Convert.ToDouble(Console.ReadLine());
					Console.Clear();
					Console.Write("Введите вторую сторону: ");
					secondEdge = Convert.ToDouble(Console.ReadLine());
					Console.Clear();
					Console.Write("Введите угол: ");
					firstAngle = Convert.ToDouble(Console.ReadLine());
					thirdEdge = Math.Sqrt(Math.Pow(firstEdge, 2) + Math.Pow(secondEdge, 2) - 2 * firstEdge * secondEdge * Math.Cos(firstAngle * 3.1415 / 180));
					SecondAngle();
					thirdAngle = 180 - firstAngle - secondAngle;
					Perimeter();
					HalfPerimeter();
					Area();
					RadiusСircumscribedСircle();
					RadiusInscribedСircle();
					Console.Clear();
					Console.Write("Третья сторона треугольника: ");
					Console.WriteLine("{0:0.##}", thirdEdge);
					Console.Write("Второй угол треугольника: ");
					Console.WriteLine("{0:0.##}", secondAngle);
					Console.Write("Третий угол треугольника: ");
					Console.WriteLine("{0:0.##}", thirdAngle);
					getInfo();
					break;
				default:
					Console.Clear();
					Console.WriteLine("Ошибка в выборе пункта");
					System.Threading.Thread.Sleep(2500);
					break;
			}
		}
	}
}
