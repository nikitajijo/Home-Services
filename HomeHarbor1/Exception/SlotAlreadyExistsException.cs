namespace HomeHarbor1.Exception
{
    public class SlotAlreadyExistsException : ApplicationException
    {
        public SlotAlreadyExistsException() { }
        public SlotAlreadyExistsException(string msg) : base(msg) { }
    }
}
