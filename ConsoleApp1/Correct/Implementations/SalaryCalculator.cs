using ConsoleApp1.Correct.Interfaces;
using ConsoleApp1.Correct.Models;

namespace ConsoleApp1.Correct.Implementations
{
    public class SalaryCalculator : ISalaryCalculator
    {
        public double CalculateSalary(Employee employee)
        {
            return employee.Salary * employee.SalaryVariation;
        }
    }
}
