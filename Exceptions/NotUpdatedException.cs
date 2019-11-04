using System;

namespace WebApplication1.Exceptions
{
    [Serializable]
    public class NotUpdatedException : Exception
    {
        public NotUpdatedException()
        {
            
        }

        public NotUpdatedException(string message) : base(string.Format("Data was not updated : {0}", message))
        {
            
        }
    }
}