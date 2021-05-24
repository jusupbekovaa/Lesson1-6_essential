using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3_3
{
    class Plane: Vehicle
    {
        double height;
        uint countPeople;
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public uint CountPeople
        {
            get { return countPeople; }
            set { countPeople = value; }
        }
       public Plane()
        {

        }
        public Plane(double height, uint countPeople, double price, int year, double x, double y, double speed)
            :base( x,y, price, speed, year)
        {
            this.height = height;
            this.countPeople = countPeople;
        }
        public void GetInfoPlane()
        {
            GetInfo();
            Console.WriteLine("Высота: {0} Количество пассажиров: {1}",Height,CountPeople);
        }

    }
}
