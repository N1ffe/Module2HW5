namespace Module2HW1
{
    public class Starter
    {
        private readonly Logger _logger;
        private readonly Actions _actions;
        private readonly Random _random;
        public Starter()
        {
            _logger = Logger.GetInstance();
            _actions = new Actions();
            _random = new Random();
        }
        public void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                int method = _random.Next(1, 3 + 1);
                Result result;
                switch (method)
                {
                    case 1:
                        result = _actions.Method200();
                        break;
                    case 2:
                        result = _actions.Method300();
                        break;
                    case 3:
                        result = _actions.Method400();
                        break;
                    default:
                        result = new Result(true);
                        break;
                }
                if (!result.Status)
                {
                    _logger.Write(Logger.Type.Error, result.Message);
                }
            }
            _logger.GetLog();
        }
    }
}
