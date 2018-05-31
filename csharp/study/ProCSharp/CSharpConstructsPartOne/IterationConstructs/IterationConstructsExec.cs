using System;
using System.Linq;

/// <summary>
/// 
/// </summary>
namespace CSharpConstructsPartOne.IterationConstructs
{
    class IterationConstructsExec : AIterationConstructsExecObject
    {
        public override void Exec()
        {
            Console.WriteLine("=> Iteration Constructs: ");

            ForLoopExample();

            ForEachLoopExample();

            ImplicitTypingUsedWithForeachLoop();

            WhileLoopExample();

            DoWhileLoopExample();
        }

        /// <summary>
        /// For loop Usage
        /// </summary>
        private void ForLoopExample()
        {
            Console.WriteLine("=> For Loop Usage:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Number is {0}", i);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Foreach Loop Usage
        /// </summary>
        private void ForEachLoopExample()
        {
            string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
            foreach (string c in carTypes)
            {
                Console.WriteLine(c);
            }

            int[] myInts = { 10, 20, 30, 40 };
            foreach (int i in myInts)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Using Implicit typed local variable withing foreach loop
        /// </summary>
        private void ImplicitTypingUsedWithForeachLoop()
        {

            Console.WriteLine("=> Using Implicit typed local variable withing foreach loop: ");

            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            var subset = from i in numbers where i < 10 select i;
            Console.WriteLine("Values in subset: ");

            foreach(var i in subset)
            {
                Console.Write("{0}", i);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// While Loop usage
        /// </summary>
        private void WhileLoopExample()
        {
            Console.WriteLine("=> Usaing While Loop: ");

            string userIsDone = "";

            while(userIsDone.ToLower() != "yes")
            {
                Console.WriteLine("In While loop");
                Console.WriteLine("Are you done? [yes] or [no]");
                userIsDone = Console.ReadLine();
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Do-While Loop Usage
        /// </summary>
        private void DoWhileLoopExample()
        {
            Console.WriteLine("=> Using Do-While Loop: ");

            string userIsDone = "";

            do
            {
                Console.WriteLine("In do/while loop");
                Console.Write("Are you done? [yes] or [no]");
                userIsDone = Console.ReadLine();
            } while (userIsDone.ToLower() != "yes");

            Console.WriteLine();
        }


    }
}
