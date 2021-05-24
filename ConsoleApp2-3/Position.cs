using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2_3
{
    class Position
    {
        string name;
        double salary;
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
        public double Salary {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        public Position(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public Position()
        { 
        }
    }
}
