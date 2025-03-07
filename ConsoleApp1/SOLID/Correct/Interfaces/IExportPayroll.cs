using ConsoleApp1.SOLID.Correct.Models;

namespace ConsoleApp1.SOLID.Correct.Interfaces
{
    public interface IExportPayroll
    {
        public void ExportPayrollText(Employee employee, double salary);
    }
}
