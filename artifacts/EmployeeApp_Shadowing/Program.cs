using System;

namespace EmployeeApp_Shadowing
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Manager(50000, 10000);
            Manager mgr = new Manager(50000, 10000);

            Console.WriteLine("Salary using Employee reference:");
            Console.WriteLine(emp.CalculateSalary());   // Base method

            Console.WriteLine("Salary using Manager reference:");
            Console.WriteLine(mgr.CalculateSalary());   // Child method

            Console.ReadLine();
        }
    }
}
