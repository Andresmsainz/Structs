using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Structs!");

            Employee newEmployee = new Employee();
            newEmployee.employeeName = "James";
            newEmployee.employeeJob = "Programmer";
            newEmployee.Salary = 5000;

            Console.WriteLine($"New Employee name = {newEmployee.employeeName} and his title is {newEmployee.employeeJob} with a salary of {newEmployee.Salary}");
        }
    }

    struct Employee
    {
        public string employeeName;
        public string employeeJob;
        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
