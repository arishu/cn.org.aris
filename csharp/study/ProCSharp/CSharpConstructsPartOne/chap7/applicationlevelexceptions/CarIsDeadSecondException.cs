using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap7.applicationlevelexceptions
{
    public class CarIsDeadSecondException : ApplicationException
    {
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadSecondException() { }
        public CarIsDeadSecondException(string message, string cause, DateTime time)
            :base(message)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }
    }
}
