namespace HomeHarbor1.Exception
{
    public class StatusAlreadyExistsException : ApplicationException
    {
        public StatusAlreadyExistsException() { }
        public StatusAlreadyExistsException(string msg) : base(msg) { }
    }
}
