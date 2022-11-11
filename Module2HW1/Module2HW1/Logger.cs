namespace Module2HW1
{
    public class Logger
    {
        private static Logger? instance;
        private string _log;
        private Logger()
        {
            _log = string.Empty;
        }
        public enum Type
        {
            Info,
            Warning,
            Error
        }
        public static Logger GetInstance()
        {
            if (instance is null)
            {
                instance = new Logger();
            }
            return instance;
        }
        public void Write(Type type, string message)
        {
            string logMessage = $"{DateTime.Now.TimeOfDay}: {type}: {message}\n";
            Console.Write(logMessage);
            _log += logMessage;
        }
        public void GetLog()
        {
            File.WriteAllText("log.txt", _log);
        }
    }
}
