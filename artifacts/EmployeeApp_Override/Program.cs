using System;

namespace EmployeeApp_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parent reference, child object
            Employee emp = new Manager(50000, 10000);

            Console.WriteLine("Salary using OVERRIDING:");
            Console.WriteLine(emp.CalculateSalary());

            Console.ReadLine();
        }
    }
}
