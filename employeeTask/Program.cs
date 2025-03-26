namespace employeeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Emin1", 99999999);
            Employee emp2 = new Employee("Emin2", 1111111);
            Employee emp3 = new Employee("Emin3", 3333333);
            Employee emp4 = new Employee("Emin4", 4444444);
            Employee emp5 = new Employee("Emin5", 222222222);
            Employee emp6 = new Employee("Emin6", 555555555);
            Department dep1 = new Department("IT", 5);

            dep1.AddEmployee(emp1);
            dep1.AddEmployee(emp2);
            dep1.AddEmployee(emp3);
            dep1.AddEmployee(emp4);
            dep1.AddEmployee(emp5);
            dep1.AddEmployee(emp6);
            dep1.GetAllEmployees();
        }
    }
}
