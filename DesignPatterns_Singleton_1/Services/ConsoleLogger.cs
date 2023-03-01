namespace DesignPatterns_Singleton_1.Services
{
    public sealed class ConsoleLogger : ICustomLogger
    {
        //Not needed if using through interface
        private static readonly Lazy<ConsoleLogger> lazyLogger = new Lazy<ConsoleLogger>(() => new ConsoleLogger());

        public static ConsoleLogger Instance { get { return lazyLogger.Value; } }

        public ConsoleLogger()
        {

        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }

    }
}
