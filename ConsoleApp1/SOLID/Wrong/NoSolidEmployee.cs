namespace ConsoleApp1.SOLID.Wrong
{
    internal class NoSolidEmployee
    {
        internal string Name { get; set; }
        internal string LastName { get; set; }
        internal double Salary { get; set; }
        internal double SalaryVariant { get; set; } = 1;

        internal double CalcaulateSalary()
        {
            return Salary * SalaryVariant;
        }

        internal void PrintPayroll()
        {
            File.WriteAllText($"{Name} {LastName}", $"{DateTime.UtcNow} - {Salary}");
        }

    }
}
