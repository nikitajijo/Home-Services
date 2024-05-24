namespace HomeHarbor1.Exception
{
    public class BookingNotFoundException : ApplicationException
    {
        public BookingNotFoundException() { }
        public BookingNotFoundException(string msg) : base(msg) { }
    }
}
