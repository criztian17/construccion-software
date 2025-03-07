namespace ConsoleApp1.SOLID.Wrong
{
    internal interface IWorker
    {
        void Work();
        void Break();
    }
    internal class NoSolidHumanWorker : IWorker
    {
        public void Break()
        {
            Console.WriteLine("relaxing...");
        }

        public void Work()
        {
            Console.WriteLine("working...");
        }
    }

    internal class MachineWorker : IWorker
    {
        public void Break()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("working...");
        }
    }
}
