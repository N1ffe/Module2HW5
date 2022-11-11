namespace Module2HW1
{
    public class Actions
    {
        private readonly Logger _logger;
        public Actions()
        {
            _logger = Logger.GetInstance();
        }
        public Result Method200()
        {
            _logger.Write(Logger.Type.Info, "Start method: Method200()");
            return new Result(true);
        }
        public Result Method300()
        {
            _logger.Write(Logger.Type.Warning, "Skipped logic in method: Method300()");
            return new Result(true);
        }
        public Result Method400()
        {
            return new Result(false, "I broke a logic");
        }
    }
}
