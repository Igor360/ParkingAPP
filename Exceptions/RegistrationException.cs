using System;
using System.Globalization;

namespace WebApplication1.Exceptions
{
    public class RegistrationException : Exception
    {
        public RegistrationException() : base()
        {
        }

        public RegistrationException(string message) : base(message)
        {
        }

        public RegistrationException(string message, params object[] args)
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}