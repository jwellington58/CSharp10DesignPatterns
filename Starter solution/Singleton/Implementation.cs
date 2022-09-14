namespace Singleton
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class Logger
    {
        private static Logger? _instance;

        /// <summary>
        /// Insta
        /// </summary>
        /// <returns></returns>
        public static Logger Instance
        {
            get
            {
                _instance ??= new Logger();
                return _instance;
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
