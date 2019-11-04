using System;

namespace WebApplication1.Exceptions
{
    public class NotAddedException : Exception
    {
        public NotAddedException()
        {
            
        }

        public NotAddedException(string message) : base(string.Format("Data was not added : {0}", message))
        {
            
        }
    }
}