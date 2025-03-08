using Solid.SOLID.Correct.SRP.Models;

namespace Solid.SOLID.Correct.SRP.Interfaces
{
    public interface ISalaryCalculator
    {
        public double CalculateSalary(Employee employee);
    }
}
