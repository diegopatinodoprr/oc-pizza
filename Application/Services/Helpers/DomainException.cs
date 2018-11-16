using System;
using System.Collections.Generic;
using System.Text;

namespace Helpers
{
    public abstract class DomainException : BaseException
    {
        protected DomainException(string message) : base(message)
        {
        }

        protected DomainException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
    public abstract class BaseException : Exception
    {
        protected BaseException(string message) : base(message)
        {
        }

        protected BaseException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
    public class CustomerIdNotValidException : BaseException
    {
        public CustomerIdNotValidException(string message) : base(message)
        {
        }
    }
}
