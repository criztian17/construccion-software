using ConsoleApp1.Correct.Interfaces;

namespace ConsoleApp1.Correct.Implementations
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
