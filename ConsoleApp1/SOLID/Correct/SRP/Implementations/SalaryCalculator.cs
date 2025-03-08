using Solid.SOLID.Correct.SRP.Interfaces;
using Solid.SOLID.Correct.SRP.Models;

namespace Solid.SOLID.Correct.SRP.Implementations
{
    public class SalaryCalculator : ISalaryCalculator
    {
        public double CalculateSalary(Employee employee)
        {
            if (employee.SalaryVariation <= 0)
            {
                return employee.Salary;
            }
            return employee.Salary * employee.SalaryVariation;
        }
    }
}
