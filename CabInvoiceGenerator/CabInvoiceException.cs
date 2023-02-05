using System;

namespace CabInvoiceGenerator
{
    public class CabInvoiceException : Exception
    {
        //Enum for Declaring constants
        public enum ExceptionType
        {
            INVALID_TIME,
            INVALID_DISTANCE
        }
        public ExceptionType exceptionType;

        public CabInvoiceException(ExceptionType exceptionType, string messgae) : base(messgae)
        {
            this.exceptionType = exceptionType;
        }
    }
}
