using ConsoleApp1.SOLID.Correct.Interfaces;

namespace ConsoleApp1.SOLID.Correct.Implementations
{
    public class MachineWorker : IWork
    {
        public void Work()
        {
            Console.WriteLine("machine working...");
        }
    }
}
