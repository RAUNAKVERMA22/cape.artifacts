using System;

namespace EmployeeApp_Shadowing
{
    public class Employee
    {
        protected double BasicSalary;

        public Employee(double basicSalary)
        {
            BasicSalary = basicSalary;
        }

        // NOT virtual
        public double CalculateSalary()
        {
            return BasicSalary;
        }
    }
}
