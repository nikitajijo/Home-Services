namespace HomeHarbor1.Exception
{
    public class FeedbackAlreadyExistsException : ApplicationException
    {
        public FeedbackAlreadyExistsException() { }
        public FeedbackAlreadyExistsException(string msg) : base(msg) { }
    }
}
