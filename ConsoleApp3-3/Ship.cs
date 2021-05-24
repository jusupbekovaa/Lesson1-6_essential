using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3_3
{
    class Ship: Vehicle
    {
        uint countPeople;
        string portName;
        public uint CountPeople
        {
            get { return countPeople; }
            set { countPeople = value; }
        }
        public string PortName
        {
            get { return portName; }
            set { portName = value; }
        }
        public Ship()
        {

        }
        public Ship(uint countPeople, string portName, double price, int year, double x, double y, double speed)
            : base(x, y, price, speed, year)
        {
            this.countPeople = countPeople;
            this.portName = portName;
        }
        public void GetInfoShip()
        {
            GetInfo();
            Console.WriteLine("Количество пассажиров: {0} Порт: {1}", CountPeople, PortName);
        }

    }
}
