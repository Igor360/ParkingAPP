using System;

namespace WebApplication1.Exceptions
{
    [Serializable]
    public class NotFoundException : Exception
    {
        public NotFoundException()
        {
            
        }

        public NotFoundException(string message) : base(String.Format("Data not found: {0}", message))
        {
            
        }
    }
}