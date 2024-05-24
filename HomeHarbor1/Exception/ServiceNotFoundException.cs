namespace HomeHarbor1.Exception
{
    public class ServiceNotFoundException : ApplicationException
    {
        public ServiceNotFoundException() { }
        public ServiceNotFoundException(string msg) : base(msg) { }
    }
}
