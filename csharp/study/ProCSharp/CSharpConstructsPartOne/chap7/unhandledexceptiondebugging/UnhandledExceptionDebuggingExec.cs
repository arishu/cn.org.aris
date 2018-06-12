using CoreCSharpPrograming.chap7.simplestexample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap7.unhandledexceptiondebugging
{
    class UnhandledExceptionDebuggingExec : AChapt7ExecObject
    {
        public override void Exec()
        {
            UnhandledExceptionDebugging();
        }

        /// <summary>
        /// Unhandled Exception Debugging
        /// </summary>
        private void UnhandledExceptionDebugging()
        {
            Console.WriteLine("=> Unhandled Exception Debugging: ");

            Console.WriteLine("Creating a car and stepping on it!");
            Car myCar = new Car("Zippy", 90);
            myCar.CrankTunes(true);

            myCar.Accelerate(2000);

            Console.WriteLine();
        }
    }
}
