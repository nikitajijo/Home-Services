namespace HomeHarbor1.Exception
{
    public class UserAlreadyExistsException : ApplicationException
    {
        public UserAlreadyExistsException() { }
        public UserAlreadyExistsException(string msg) : base(msg) { }
    }
}
