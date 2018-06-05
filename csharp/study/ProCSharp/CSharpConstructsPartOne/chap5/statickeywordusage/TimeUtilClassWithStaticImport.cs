using System;
using static System.DateTime;
using static System.Console;

namespace CoreCSharpPrograming.chap5.statickeywordusage
{
    static class TimeUtilClassWithStaticImport
    {
        /// <summary>
        /// Print Current Time in short time format
        /// </summary>
        public static void PrintTime() => WriteLine(Now.ToShortTimeString());

        /// <summary>
        /// Print Current Date in short date format
        /// </summary>
        public static void PrintDate() => WriteLine(Today.ToShortDateString());
    }
}
