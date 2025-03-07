using ConsoleApp1.SOLID.Correct.Interfaces;
using ConsoleApp1.SOLID.Correct.Models;

namespace ConsoleApp1.SOLID.Correct.Implementations
{
    internal class ExportPayrollService : IExportPayroll
    {
        public void ExportPayrollText(Employee employee, double salary)
        {
            File.WriteAllText($"{employee.Name} {employee.LastName}", $"{DateTime.UtcNow} - {salary}");
        }
    }
}
