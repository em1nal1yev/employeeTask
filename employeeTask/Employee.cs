using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeTask
{
    class Employee
    {
        public string name;
        public int salary;
        public Employee(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public void Info()
        {
            Console.WriteLine($"Adi: {name}, Maasi: {salary}");
        }
    }
}