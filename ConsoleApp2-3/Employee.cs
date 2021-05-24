using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2_3
{
    class Employee
    {
        string surname;
        string name;
        int experience;
        Position position;
        public Position Position { get; set; }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
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

        public int Experience
        {
            get
            {
                return experience;
            }
            set
            {
                experience = value;
            }
        }
        public Employee(string surname, string name,int experience, Position position)
        {
            this.name = name;
            this.surname = surname;
            this.experience = experience;
            this.position = position;
        }
        public Employee() { }
        public void SalaryCalc(Employee employee)
        {
            double salary = (employee.position.Salary * (employee.experience /10))+ employee.position.Salary;
            double finishSalary = salary * 0.95;
            Console.WriteLine("Заработная плата: " + finishSalary);
        }
        public void TaxCalc(Employee employee)
        {
            double tax = ((employee.position.Salary * (employee.experience / 10)) + employee.position.Salary) * 0.05;
            Console.WriteLine("Налоговый сбор: " + tax);
        }
        public void GetEmployee(Employee employee)
        {
            Console.WriteLine("ФИО:{0} {1} Должность:{2} Оклад: {3} Опыт работы:{4}", employee.Surname, employee.Name, employee.position.Name,employee.position.Salary ,employee.Experience);
        }
    }
}