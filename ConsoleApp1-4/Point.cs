using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_4
{
    class Point
    {
        int x,y;
        string name;
        public int X
        {
            get
            {
                return x;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public Point()
            : this(" ", 0, 0) { }
        public Point(string name, int x, int y)
        {
            Console.WriteLine("Введите имя точки:");
            this.name = Console.ReadLine();
            Console.WriteLine("Координата X:");
            this.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Координата Y:");
            this.y = int.Parse(Console.ReadLine());
        }
    }
}
