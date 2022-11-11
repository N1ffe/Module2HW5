namespace Module2HW1
{
    public class Result
    {
        public Result(bool status, string? message = null)
        {
            Status = status;
            Message = message;
        }
        public bool Status { get; private set; }
        public string? Message { get; private set; }
    }
}
