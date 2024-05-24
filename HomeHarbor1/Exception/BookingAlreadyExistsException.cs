namespace HomeHarbor1.Exception
{
    public class BookingAlreadyExistsException : ApplicationException
    {
        public BookingAlreadyExistsException() { }
        public BookingAlreadyExistsException(string msg) : base(msg) { }
    }
}
