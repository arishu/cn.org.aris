using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreCSharpPrograming.chap3.StringData;
using CoreCSharpPrograming.chap5.CSharpEncapsulation;
using CoreCSharpPrograming.chap7.unhandledexceptiondebugging;

namespace CoreCSharpPrograming
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chap3Exec();
            
            // Chap5Exec();

            Chap7Exec();
        }

        private static void Chap3Exec()
        {
            // String Manipulation
            new StringDataExec().Exec();
        }

        private static void Chap5Exec()
        {
            new CSharpEncapsulationServices().Exec();
        }

        private static void Chap7Exec()
        {
            new UnhandledExceptionDebuggingExec().Exec();
        }
    }
}
