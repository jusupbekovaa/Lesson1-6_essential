using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3_3
{
    class Vehicle
    {
        double x, y, price, speed;
        int year;
        public double X
        {
            get{return x;}
            set{ x = value;}
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public Vehicle()
        {

        }
        public Vehicle (double x,double y,double price,double speed, int year)
        {
            this.x = x;
            this.y = y;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }
        protected void GetInfo()
        {
            Console.WriteLine("Координата Х:{0} Координата Y:{1} Цена:{2} Скорость:{3} Год выпуска:{4}", X, Y, Price, Speed, Year);
        }
    }
}
