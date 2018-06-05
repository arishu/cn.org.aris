using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap5.statickeywordusage
{
    static class TimeUtilClass
    {
        /// <summary>
        /// Print Current Time in short time format
        /// </summary>
        public static void PrintTime()
            => Console.WriteLine(DateTime.Now.ToShortTimeString());

        /// <summary>
        /// Print Current Date in short date format
        /// </summary>
        public static void PrintDate()
            => Console.WriteLine(DateTime.Today.ToShortDateString());
    }
}
