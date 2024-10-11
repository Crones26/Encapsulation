//#define DISTANCE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	internal class Program
	{
		static void Main(string[] args)
		{

#if DISTANCE
			//Point A = new Point();
			//Console.WriteLine($"X={A.GetX()}\tY={A.GetY()}");
			//A.SetX(2000);
			//A.SetY(3000);
			//A.Print();

			//A.X = 22;
			//A.Y = 33;
			//A.Print();

			// Создаем две точки
			Point A = new Point { X = 22, Y = 33 };
			Point B = new Point { X = 10, Y = 20 };

			// Выводим координаты точек
			A.Print();
			B.Print();

			// Не статический метод Distance (расстояние от A до B)
			double distanceToB = A.Distance(B);
			Console.WriteLine($"Расстояние от точки A до точки B: {distanceToB}");

			// Статический метод Distance (расстояние между A и B)
			double distanceBetween = Point.Distance(A, B);
			Console.WriteLine($"Расстояние между точками A и B: {distanceBetween}"); 
#endif

			Point A = new Point(2, 3);
			Point B = new Point(7, 8);
			Point C = new Point(A + B);
			C.Print();
			Point D = new Point(A - B);
			D.Print();

			for (Point i = new Point(); i.X < 10; i++)
			{
				i.Print();
			}
		}
	}
}
