using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_2
{
    class Rectangle
    {
        public double side1;
        public double side2;
        public double Area
        {
            get { return AreaCalculator(); }
        }
        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculator()
        {
            double result = side1 * side2;
            return result;
        }
        public double PerimeterCalculator()
        {
            double result = (side1 + side2) * 2;
            return result;
        }
    }
}
