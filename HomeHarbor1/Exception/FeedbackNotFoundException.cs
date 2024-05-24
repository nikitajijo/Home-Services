namespace HomeHarbor1.Exception
{
    public class FeedbackNotFoundException : ApplicationException
    {
        public FeedbackNotFoundException() { }
        public FeedbackNotFoundException(string msg) : base(msg) { }
    }
}
