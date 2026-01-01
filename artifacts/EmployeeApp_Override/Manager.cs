using System;

namespace EmployeeApp_Override
{
    public class Manager : Employee
    {
        private double Allowance;

        public Manager(double basicSalary, double allowance)
            : base(basicSalary)
        {
            Allowance = allowance;
        }

        // Overriding base class method
        public override double CalculateSalary()
        {
            return BasicSalary + Allowance;
        }
    }
}
