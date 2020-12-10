using System;

namespace NoTenKee.AppException
{
    public class NoTenKeeException : SystemException
    {
        public NoTenKeeException(string message) : base(message) { }
        public NoTenKeeException(string message, System.Exception innerException) : base(message, innerException) { }
    }
}
