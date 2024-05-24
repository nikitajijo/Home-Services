namespace HomeHarbor1.Exception
{
    public class StatusNotFoundException : ApplicationException
    {
        public StatusNotFoundException() { }
        public StatusNotFoundException(string msg) : base(msg) { }
    }
}
