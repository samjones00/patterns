using System;
using System.Runtime.Serialization;

namespace Patterns.Factory.Exceptions
{
    class VehicleNotSupportedException : NotSupportedException
    {
        public VehicleNotSupportedException()
        {
        }

        public VehicleNotSupportedException(string message) : base(message)
        {
        }

        public VehicleNotSupportedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected VehicleNotSupportedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
