namespace HomeHarbor1.Exception
{
    public class UserNotFoundException : ApplicationException
    {
        public UserNotFoundException() { }
        public UserNotFoundException(string msg) : base(msg) { }
    }
}
