using System;

namespace EmployeeApp_Shadowing
{
    public class Manager : Employee
    {
        private double Allowance;

        public Manager(double basicSalary, double allowance)
            : base(basicSalary)
        {
            Allowance = allowance;
        }

        // Shadowing using 'new'
        public new double CalculateSalary()
        {
            return BasicSalary + Allowance;
        }
    }
}
