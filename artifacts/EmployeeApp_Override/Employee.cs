using System;

namespace EmployeeApp_Override
{
    public class Employee
    {
        protected double BasicSalary;

        public Employee(double basicSalary)
        {
            BasicSalary = basicSalary;
        }

        // Virtual method
        public virtual double CalculateSalary()
        {
            return BasicSalary;
        }
    }
}
