﻿namespace HomeHarbor1.Exception
{
    public class ServiceAlreadyExistsException : ApplicationException
    {
        public ServiceAlreadyExistsException() { }
        public ServiceAlreadyExistsException(string msg) : base(msg) { }
    }
}
