using ConsoleApp1.SOLID.Correct.Interfaces;

namespace ConsoleApp1.SOLID.Correct.Implementations
{
    public class HumanWorker : IWork, IBreak
    {
        public void Break()
        {
            Console.WriteLine("relaxing...");
        }

        public void Work()
        {
            Console.WriteLine("Human working...");
        }
    }
}
