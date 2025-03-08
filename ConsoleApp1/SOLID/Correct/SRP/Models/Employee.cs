namespace Solid.SOLID.Correct.SRP.Models
{
    public record Employee
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public double Salary { get; set; }

        public double SalaryVariation { get; set; } = 1;
    }
}
