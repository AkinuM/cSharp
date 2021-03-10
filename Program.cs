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
			Console.Write("Варианты ввода:\n1. Три стороны\n2. Сторона и два угла\n3. Две стороны и угол\n4. Высота, угол и сторона\n\nВыберите пункт: ");
			int choice = Convert.ToInt32(Console.ReadLine());
			int firstEdge, secondEdge, thirdEdge, firstAngle, secondAngle, thirdAngle, height;
			switch (choice)
			{
				case 1:
					Console.Clear();
					Console.Write("Введите первую сторону: ");
					firstEdge = Convert.ToInt32(Console.ReadLine());
					Console.Clear();
					Console.Write("Введите вторую сторону: ");
					secondEdge = Convert.ToInt32(Console.ReadLine());
					Console.Clear();
					Console.Write("Введите третью сторону: ");
					thirdEdge = Convert.ToInt32(Console.ReadLine());
					int perimeter = firstEdge + secondEdge + thirdEdge;
					int halfPerimeter = perimeter / 2;
					double area = Math.Sqrt(halfPerimeter * Math.Sqrt(halfPerimeter - firstEdge) * Math.Sqrt(halfPerimeter - secondEdge) * Math.Sqrt(halfPerimeter - thirdEdge));
					firstAngle = firstEdge * 180 / perimeter;
					secondAngle = secondEdge * 180 / perimeter;
					thirdAngle = thirdEdge * 180 / perimeter;
					double radiusСircumscribedСircle = firstEdge * secondEdge * thirdEdge / 4 / area;
					double radiusInscribedСircle = area / halfPerimeter;
					Console.Clear();
					Console.Write($"Первый угол треугольника: {firstAngle}\nВторой угол треугольника: {secondAngle}\nТретий угол треугольника: {thirdAngle}\nПериметр треугольника: {perimeter}\nПлощадь треугольника: {area}\nРадиус описанной окружности: {radiusСircumscribedСircle}\nРадиус вписанной окружности: {radiusInscribedСircle}\n");
					break;
				case 2:
					Console.Clear();
					Console.Write("Введите сторону: ");
					firstEdge = Convert.ToInt32(Console.ReadLine());
					Console.Clear();
					Console.Write("Введите первый угол: ");
					firstAngle = Convert.ToInt32(Console.ReadLine());
					Console.Clear();
					Console.Write("Введите второй угол: ");
					secondAngle = Convert.ToInt32(Console.ReadLine());
					break;
				case 3:
					Console.Clear();
					Console.Write("Введите первую сторону: ");
					firstEdge = Convert.ToInt32(Console.ReadLine());
					Console.Clear();
					Console.Write("Введите вторую сторону: ");
					secondEdge = Convert.ToInt32(Console.ReadLine());
					Console.Clear();
					Console.Write("Введите угол: ");
					firstAngle = Convert.ToInt32(Console.ReadLine());
					break;
				case 4:
					Console.Clear();
					Console.Write("Введите высоту: ");
					height = Convert.ToInt32(Console.ReadLine());
					Console.Clear();
					Console.Write("Введите угол: ");
					firstAngle = Convert.ToInt32(Console.ReadLine());
					Console.Clear();
					Console.Write("Введите сторону: ");
					firstEdge = Convert.ToInt32(Console.ReadLine());
					break;
				default:
					Console.Clear();
					Console.Write("Ошибка в выборе пункта");
					System.Threading.Thread.Sleep(2500);
					break;
			}
		}
	}
}
