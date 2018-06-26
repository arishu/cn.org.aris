using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap10.anonymousmethods
{
    class AnonymousMethodUsageExec : AChap10ExecObject
    {
        public override void Exec()
        {
            try
            {
                BasicAnonymousMethodUsage();

                OuterVariablesOfAnonymousMethod();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in AnonymousMethodUsageExec.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// Basic Anonymous Method
        /// </summary>
        private void BasicAnonymousMethodUsage()
        {
            Console.WriteLine("=> Basic Anonymous Method: ");

            Car c1 = new Car("SlugBug", 100, 10);

            c1.AboutToBlow += delegate
            {
                Console.WriteLine("Eek! Going too fast!");
            };

            c1.AboutToBlow += delegate (object sender, CarEventArgs e)
            {
                Console.WriteLine("Message from Car: {0}", e.msg);
            };

            c1.Exploded += delegate (object sender, CarEventArgs e)
            {
                Console.WriteLine("Fatal Message from Car: {0}", e.msg);
            };

            Console.WriteLine("-> Speed Up: ");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Outer variable of Anonymous Method Usage
        /// </summary>
        private void OuterVariablesOfAnonymousMethod()
        {
            Console.WriteLine("=> Outer variable of Anonymous Method Usage:");
            int aboutToBlowCounter = 0;

            // Make a car as usual.
            Car c1 = new Car("SlugBug", 100, 10);

            // Register event handlers as anonymous methods
            c1.AboutToBlow += delegate
            {
                aboutToBlowCounter++;
                Console.WriteLine("Eek! Going too fast!");
            };

            c1.AboutToBlow += delegate (object sender, CarEventArgs e)
            {
                aboutToBlowCounter++;
                Console.WriteLine("Message from Car: {0}", e.msg);
            };

            c1.Exploded += delegate (object sender, CarEventArgs e)
            {
                aboutToBlowCounter++;
                Console.WriteLine("Fatal Message from Car: {0}", e.msg);
            };

            // This will eventually trigger the events
            Console.WriteLine("-> Speed Up: ");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            Console.WriteLine("AboutToBlow event was fired {0} times.", aboutToBlowCounter);

            Console.WriteLine();
        }
    }
}
