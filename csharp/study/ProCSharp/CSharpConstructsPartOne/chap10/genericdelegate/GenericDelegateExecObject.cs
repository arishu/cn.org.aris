using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap10.genericdelegate
{
    // This generic delegate can represent any method
    // returning void and taking a single parameter of type T
    public delegate void MyGenericDelegate<T>(T arg);

    class GenericDelegateExecObject : AChap10ExecObject
    {
        public override void Exec()
        {
            try
            {
                GenericDelegateUsage();

                ActionDelegateUsage();

                FuncDelegateUsage();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in GenericDelegateExecObject.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        static void StringTarget(string arg)
        {
            Console.WriteLine("arg in uppercase is: {0}", arg.ToUpper());
        }

        static void IntTarget(int arg)
        {
            Console.WriteLine("++arg is: {0}", ++arg);
        }

        /// <summary>
        /// Generic Delegate Usage
        /// </summary>
        private void GenericDelegateUsage()
        {
            Console.WriteLine("=> Generic Delegate Usage: ");

            // Register targets.
            MyGenericDelegate<string> strTarget = new 
                MyGenericDelegate<string>(StringTarget);
            strTarget("Some string data");

            MyGenericDelegate<int> intTarget = new 
                MyGenericDelegate<int>(IntTarget);
            intTarget(9);

            Console.WriteLine();
        }

        // This is a target for the Action<> delegate.
        static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
        {
            // Set color of console text.
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;
            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }
            // Restore color.
            Console.ForegroundColor = previous;
        }

        /// <summary>
        /// Action<> Delegate Usage
        /// </summary>
        private void ActionDelegateUsage()
        {
            Console.WriteLine("=> Action<> Delegate Usage: ");

            Action<string, ConsoleColor, int> actionTarget = new Action<string, ConsoleColor, int>(DisplayMessage);
            actionTarget("Action Message", ConsoleColor.Yellow, 5);

            Console.WriteLine();
        }

        // Target for the Func<> delegate.
        static int Add(int x, int y)
        {
            return x + y;
        }

        // Target for the Func<> delegate.
        static string SumToString(int x, int y)
        {
            return (x + y).ToString();
        }

        /// <summary>
        /// Func<> Delegate Usage
        /// </summary>
        private void FuncDelegateUsage()
        {
            Console.WriteLine("=> Func<> Delegate Usage");

            // Two formats are OK
            // Func<int, int, int> funcTarget = new Func<int, int, int>(Add);
            Func<int, int, int> funcTarget = Add;
            int result = funcTarget.Invoke(40, 40);
            Console.WriteLine("40 + 40 = {0}", result);

            // Two formats are OK
            // Func<int, int, string> funcTarget2 = new Func<int, int, string>(SumToString);
            Func<int, int, string> funcTarget2 = SumToString;
            string sum = funcTarget2.Invoke(90, 300);
            Console.WriteLine(sum);

            Console.WriteLine();
        }
    }
}
