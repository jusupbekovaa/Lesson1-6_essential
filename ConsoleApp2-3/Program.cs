using System;

namespace ConsoleApp2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Position position1 = new Position("Директор", 95000);
            Position position2 = new Position("Бухгалтер", 63000);
            Employee employee1 = new Employee("Иванов", "Иван", 5, position1);
            Employee employee = new Employee();
            employee.GetEmployee(employee1);
            employee.SalaryCalc(employee1);
            employee.TaxCalc(employee1);

            
        }
    }
}
