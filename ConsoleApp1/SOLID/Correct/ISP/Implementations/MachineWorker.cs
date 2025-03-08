using Solid.SOLID.Correct.ISP.Interfaces;

namespace Solid.SOLID.Correct.ISP.Implementations
{
    public class MachineWorker : IWork
    {
        public void Work()
        {
            Console.WriteLine("machine working...");
        }
    }
}
