using ConsoleApp1.Correct.Models;

namespace ConsoleApp1.Correct.Interfaces
{
    public interface IExportPayroll
    {
        public void ExportPayrollText(Employee employee, double salary);
    }
}
