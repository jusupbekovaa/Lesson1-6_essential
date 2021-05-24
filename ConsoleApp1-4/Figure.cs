using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_4
{
    class Figure
    {
        int number;
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        Point[] points;
        public void InitializeFigure()
        {
            Console.WriteLine("Введите количество точек вашей фигуры: ");
            number = int.Parse(Console.ReadLine());
            switch(number)
            {
                case 3:
                    Console.WriteLine("Треугольник");
                    break;
                case 4:
                    Console.WriteLine("Прямоугольник");
                    break;
                case 5:
                    Console.WriteLine("Пятиугольник");
                    break;
                default:
                    Console.WriteLine("Многоугольник");
                    break;

            }
            points = new Point[number];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point();
            }

        }
        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
        public double CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 1; i < points.Length; i++)
            {
                perimeter += this.LengthSide(points[i - 1], points[i]);
            }
            perimeter += this.LengthSide(points[0], points[points.Length - 1]);
            return perimeter;
        }
        public Figure()
        {
            InitializeFigure();
        }

    }
}
