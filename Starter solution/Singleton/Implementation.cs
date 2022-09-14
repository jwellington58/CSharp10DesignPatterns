namespace Singleton
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class Logger
    {
        private static readonly Lazy<Logger> _lazyLogger 
            = new(() => new Logger());

        /// <summary>
        /// Insta
        /// </summary>
        /// <returns></returns>
        public static Logger Instance
        {
            get
            {
                return _lazyLogger.Value;
            }
        }

        protected Logger()
        {

        }

        public void Log(string message)
        {
            Console.WriteLine($"Message is {message}");
        }
    }
}
