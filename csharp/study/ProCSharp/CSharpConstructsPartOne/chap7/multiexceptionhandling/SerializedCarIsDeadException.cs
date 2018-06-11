using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap7.multiexceptionhandling
{
    public class SerializedCarIsDeadException : ApplicationException
    {
        public SerializedCarIsDeadException() { }
        public SerializedCarIsDeadException(string message) : base(message) { }
        public SerializedCarIsDeadException(string message, System.Exception inner)
            : base(message, inner) { }
        protected SerializedCarIsDeadException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }

        // Any additional custom properties, constructors and data members
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public SerializedCarIsDeadException(string message, string cause, DateTime time)
            : base(message)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }
    }
}
