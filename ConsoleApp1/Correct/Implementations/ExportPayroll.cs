using ConsoleApp1.Correct.Models;
using ConsoleApp1.Correct.Interfaces;

namespace ConsoleApp1.Correct.Implementations
{
    internal class ExportPayrollService : IExportPayroll
    {
        public void ExportPayrollText(Employee employee, double salary)
        {
            File.WriteAllText($"{employee.Name} {employee.LastName}", $"{DateTime.UtcNow} - {salary}");
        }
    }
}
