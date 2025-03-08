using Solid.SOLID.Correct.SRP.Models;

namespace Solid.SOLID.Correct.SRP.Interfaces
{
    public interface IExportPayroll
    {
        public void ExportPayrollText(Employee employee, double salary);
    }
}
