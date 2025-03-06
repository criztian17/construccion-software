using ConsoleApp1.Correct.Interfaces;

namespace ConsoleApp1.Correct.Implementations
{
    public class MachineWorker : IWork
    {
        public void Work()
        {
            Console.WriteLine("machine working...");
        }
    }
}
