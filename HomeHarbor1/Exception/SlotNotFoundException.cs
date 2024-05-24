namespace HomeHarbor1.Exception
{
    public class SlotNotFoundException : ApplicationException
    {
        public SlotNotFoundException() { }
        public SlotNotFoundException(string msg) : base(msg) { }
    }
}
