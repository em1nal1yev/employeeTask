using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace employeeTask
{
    class Department
    {
        public string name;
        public int employeeLimit;
        public string[] employees = new string[0];

        public Department(string name, int employeeLimit)
        {
            this.name = name;
            this.employeeLimit = employeeLimit;
        }

        public void AddEmployee(Employee e)
        {
            if(employeeLimit > employees.Length) 
            {
                string[] empp = new string[employees.Length + 1];
                for(int i = 0; i <= empp.Length; i++)
                {
                    if (i == employees.Length)  
                    {
                        empp[i] = e.name;
                        employees = empp;
                        empp = employees;
                        break;
                    }

                }
            }
            else
            {
                Console.WriteLine($"{e.name} qoymaqcun yer qalmadi!!");
            }
        }

        public void GetAllEmployees()
        {
            for(int i = 0; i<employees.Length; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
    }
}
