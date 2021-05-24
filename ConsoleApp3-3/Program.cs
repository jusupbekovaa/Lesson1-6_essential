using System;

namespace ConsoleApp3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane1 = new Plane(200,150, 12000, 2003, 10,11,250);
            plane1.GetInfoPlane();
            Ship ship1 = new Ship(50, "port 1", 150000, 2003, 5, 6, 80);
            ship1.GetInfoShip();

        }
    }
}
