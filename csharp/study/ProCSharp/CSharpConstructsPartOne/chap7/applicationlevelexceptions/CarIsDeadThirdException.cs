using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap7.applicationlevelexceptions
{
    [Serializable]
    public class CarIsDeadThirdException : ApplicationException
    {
        public CarIsDeadThirdException() { }
        public CarIsDeadThirdException(string message) : base(message) { }
        public CarIsDeadThirdException(string message, System.Exception inner)
            : base(message, inner) { }
        protected CarIsDeadThirdException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }

        // Any additional custom properties, constructors and data members
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadThirdException(string message, string cause, DateTime time)
            : base(message)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }
    }
}
