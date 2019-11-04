using System;

namespace WebApplication1.Exceptions
{
    public class NotDeletedException : Exception
    {
        public NotDeletedException()
        {
            
        }

        public NotDeletedException(string message) : base(String.Format("Data was not deleted : {0}", message))
        {
            
        }
    }
}