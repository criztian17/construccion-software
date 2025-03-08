using Solid.SOLID.Correct.SRP.Interfaces;
using Solid.SOLID.Correct.SRP.Models;

namespace Solid.SOLID.Correct.SRP.Implementations
{
    internal class ExportPayrollService : IExportPayroll
    {
        public void ExportPayrollText(Employee employee, double salary)
        {
            File.WriteAllText($"{employee.Name} {employee.LastName}.txt", $"{DateTime.UtcNow} - {salary}");
        }
    }
}
