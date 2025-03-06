using ConsoleApp1.Correct.Implementations;
using ConsoleApp1.Correct.Models;

public class Program
{
    static void Main()
    {
        #region SRP

        Employee employee = new() { Name = "Pepe", LastName = "Jaramillo", Salary = 7500, SalaryVariation = 1.2 };

        SalaryCalculator salaryCalculatorService = new ();

        var salaryResult = salaryCalculatorService.CalculateSalary(employee);

        ExportPayrollService exportPayrollService = new ();

        exportPayrollService.ExportPayrollText(employee, salaryResult);

        #endregion


        #region ISP

        HumanWorker worker = new ();
        worker.Break();
        worker.Work();

        MachineWorker machineWorker = new ();
        machineWorker.Work();

        #endregion

    }
}