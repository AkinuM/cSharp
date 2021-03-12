using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace triangle
{
	class Program
	{
		static void Main(string[] args)
		{
			bool Continue = false;
			double firstEdge, secondEdge, thirdEdge, firstAngle, secondAngle, thirdAngle, perimeter, halfPerimeter, area, radiusСircumscribedСircle, radiusInscribedСircle, choice;

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
				firstAngle = Math.Acos((Math.Pow(secondEdge, 2) + Math.Pow(thirdEdge, 2) - Math.Pow(firstEdge, 2)) / 2 / secondEdge / thirdEdge) * 180 / Math.PI;
			}

			void SecondAngle()
			{
				secondAngle = Math.Acos((Math.Pow(firstEdge, 2) + Math.Pow(thirdEdge, 2) - Math.Pow(secondEdge, 2)) / 2 / firstEdge / thirdEdge) * 180 / Math.PI;
			}

			void ThirdAngle()
			{
				thirdAngle = Math.Acos((Math.Pow(secondEdge, 2) + Math.Pow(firstEdge, 2) - Math.Pow(thirdEdge, 2)) / 2 / secondEdge / firstEdge) * 180 / Math.PI;
			}

			void RadiusСircumscribedСircle()
			{
				radiusСircumscribedСircle = firstEdge * secondEdge * thirdEdge / 4 / area;
			}

			void RadiusInscribedСircle()
			{
				radiusInscribedСircle = area / halfPerimeter;
			}

			void input(out double variable)
			{
				string tempVariable = Console.ReadLine();
				IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
				if (!double.TryParse(tempVariable, NumberStyles.AllowDecimalPoint, formatter, out variable))
				{
					Console.Clear();
					Console.WriteLine("Некорректный ввод");
					System.Threading.Thread.Sleep(2500);
					Continue = true;
				}
				else if(tempVariable == "0")
				{
					Console.Clear();
					Console.WriteLine("Некорректный ввод");
					System.Threading.Thread.Sleep(2500);
					Continue = true;
				}
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

			while (true)
			{
				Console.Clear();
				Continue = false;
				Console.Write("Варианты ввода:\n1. Три стороны\n2. Сторона и два угла\n3. Две стороны и угол\n\nВыберите пункт: ");
				input(out choice);
				if (Continue == true)
				{
					continue;
				}
				switch (choice)
				{
					case 1:
						while (true)
						{
							Console.Clear();
							Continue = false;
							Console.Write("Введите первую сторону: ");
							input(out firstEdge);
							if (Continue == false)
							{
								break;
							}
						}
						while (true)
						{
							Continue = false;
							Console.Clear();
							Console.Write("Введите вторую сторону: ");
							input(out secondEdge);
							if (Continue == false)
							{
								break;
							}
						}
						while (true)
						{
							Continue = false;
							Console.Clear();
							Console.Write("Введите третью сторону: ");
							input(out thirdEdge);
							if (Continue == false)
							{
								break;
							}
						}
						if (firstEdge + secondEdge <= thirdEdge || firstEdge + thirdEdge <= secondEdge || secondEdge + thirdEdge <= firstEdge)
						{
							Console.Clear();
							Console.WriteLine("Такого треугольника не существует");
							System.Threading.Thread.Sleep(2500);
							continue;
						}
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
						Environment.Exit(0);
						break;
					case 2:
						while (true)
						{
							Continue = false;
							Console.Clear();
							Console.Write("Введите сторону: ");
							input(out firstEdge);
							if (Continue == false)
							{
								break;
							}
						}
						while (true)
						{
							Continue = false;
							Console.Clear();
							Console.Write("Введите первый угол: ");
							input(out firstAngle);
							if (Continue == true)
							{
								continue;
							}
							if (firstAngle > 178)
							{
								Console.Clear();
								Console.WriteLine("Такого треугольника не существует");
								System.Threading.Thread.Sleep(2500);
								continue;
							}
							break;
							
						}
						while (true)
						{
							Continue = false;
							Console.Clear();
							Console.Write("Введите второй угол: ");
							input(out secondAngle);
							if (Continue == true)
							{
								continue;
							}
							if (secondAngle > 179 - firstAngle)
							{
								Console.Clear();
								Console.WriteLine("Такого треугольника не существует");
								System.Threading.Thread.Sleep(2500);
								continue;
							}
							break;
						}
						thirdAngle = 180 - firstAngle - secondAngle;
						secondEdge = firstEdge * Math.Sin(secondAngle * Math.PI / 180) / Math.Sin(thirdAngle * Math.PI / 180);
						thirdEdge = firstEdge * Math.Sin(firstAngle * Math.PI / 180) / Math.Sin(thirdAngle * Math.PI / 180);
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
						Environment.Exit(0);
						break;
					case 3:
						while (true)
						{
							Continue = false;
							Console.Clear();
							Console.Write("Введите первую сторону: ");
							input(out firstEdge);
							if (Continue == true)
							{
								continue;
							}
							break;
						}
						while (true)
						{
							Continue = false;
							Console.Clear();
							Console.Write("Введите вторую сторону: ");
							input(out secondEdge);
							if (Continue == true)
							{
								continue;
							}
							break;
						}
						while (true)
						{
							Continue = false;
							Console.Clear();
							Console.Write("Введите угол: ");
							input(out firstAngle);
							if (Continue == true)
							{
								continue;
							}
							if (firstAngle > 178)
							{
								Console.Clear();
								Console.WriteLine("Такого треугольника не существует");
								System.Threading.Thread.Sleep(2500);
								continue;
							}
							break;
						}
						thirdEdge = Math.Sqrt(Math.Pow(firstEdge, 2) + Math.Pow(secondEdge, 2) - 2 * firstEdge * secondEdge * Math.Cos(firstAngle * Math.PI / 180));
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
						Environment.Exit(0);
						break;
					default:
						Console.Clear();
						Console.WriteLine("Некорректный ввод");
						System.Threading.Thread.Sleep(2500);
						break;
				}
			}
		}
	}
}