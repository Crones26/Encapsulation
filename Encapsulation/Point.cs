using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	internal class Point
	{
		#region Double
		//double x;
		//double y;
		//public double X // Property 
		//{ 
		//	get 
		//	{ 
		//		return x; 
		//	}
		//	set 
		//	{
		//		if(value>200)value = 200;
		//		x = value; // ключевое слово value дает применяемое значение
		//	} 
		//}
		//public double Y
		//{ 
		//	get 
		//	{ 
		//		return y; 
		//	}
		//	set 
		//	{
		//		if (value>150)value = 150;
		//		y = value;
		//	}
		//}
		//public double GetX()
		//{
		//	return x;
		//}
		//public double GetY() 
		//{
		//	return y;
		//}
		//public void SetX(double x) 
		//{
		//	if (x > 200) x = 200;
		//	this.x = x;
		//}
		//public void SetY(double y)
		//{
		//	if (y > 150) y = 150;
		//	this.y = y;
		//} 
		#endregion


		public double X { get; set; }
		public double Y { get; set; }

		// Метод для вывода значений X и Y
		public void Print()
		{
			Console.WriteLine($"X={X}\tY={Y}");
		} 

		// Метод для вычисления расстояния до другой точки
		public double Distance(Point other)
		{
			return Math.Sqrt(Math.Pow(this.X - other.X, 2) + Math.Pow(this.Y - other.Y, 2));
		}

		// Статический метод для вычисления расстояния между двумя точками
		public static double Distance(Point p1, Point p2)
		{
			return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
		}

	}
}
