using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap7.simplestexample
{
    class SimplestExampleExec : AChapt7ExecObject
    {
        public override void Exec()
        {
            try
            {
                SimpleExceptionExample();

                CatchException();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in SimplestExampleExec.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// Simple Exception Example
        /// </summary>
        private void SimpleExceptionExample()
        {
            Console.WriteLine("=> Simple Exception Example: ");

            Console.WriteLine("Creating a car and stepping on it!");
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);

            for (int i = 0; i < 10; i++)
                myCar.Accelerate(10);

            Console.WriteLine();
        }

        /// <summary>
        /// Catch an Exception
        /// </summary>
        private void CatchException()
        {
            Console.WriteLine("=> Catch an Exception: ");

            Console.WriteLine("Creating a car and stepping on it!");
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);

            try
            {
                for (int i = 0; i < 10; i++)
                    myCar.Accelerate(10);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n**** Error! ****");
                Console.WriteLine("Method: {0}", e.TargetSite);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
            }

            Console.WriteLine("**** Out of exception logic ****");

            Console.WriteLine();
        }
    }
}
