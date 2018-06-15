﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreCSharpPrograming.chap3.StringData;
using CoreCSharpPrograming.chap5.CSharpEncapsulation;
using CoreCSharpPrograming.chap7.unhandledexceptiondebugging;
using CoreCSharpPrograming.chap8.ienumerableandienumerator;
using CoreCSharpPrograming.chap8.icloneableinterface;
using CoreCSharpPrograming.chap8.icomparableinterface;

namespace CoreCSharpPrograming
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chap3Exec();

            // Chap5Exec();

            // Chap7Exec();

            Chap8Exec();
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

        private static void Chap8Exec()
        {
            // new IEnumerableAndIEnumeratorInterfaceUsageExec().Exec();

            // new ICloneableInterfaceUsageExec().Exec();

            new IComparableInterfaceExec().Exec();
        }
    }
}
