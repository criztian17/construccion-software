using ConsoleApp1.SOLID.Correct.Interfaces;
using ConsoleApp1.SOLID.Correct.Models;

namespace ConsoleApp1.SOLID.Correct.Implementations
{
    public class SalaryCalculator : ISalaryCalculator
    {
        public double CalculateSalary(Employee employee)
        {
            return employee.Salary * employee.SalaryVariation;
        }
    }
}
