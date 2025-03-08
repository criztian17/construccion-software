using Solid.SOLID.Correct.ISP.Interfaces;

namespace Solid.SOLID.Correct.ISP.Implementations
{
    public class HumanWorker : IWork, IBreak
    {
        public void Break()
        {
            Console.WriteLine("Human taking a break...");
        }

        public void Work()
        {
            Console.WriteLine("Human working...");
        }
    }
}
