using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap10.simpledelegate
{
    // This delegate can point to any method,
    // taking two integers and returning an integer
    public delegate int BinaryOp(int x, int y);

    public class SimpleMath
    {
        public static int Add(int x, int y) => x + y;
        public static int Subtract(int x, int y) => x - y;
        public static int SquareNumber(int a) => a * 3;

        public int InstanceMethod(int x, int y) => x * 2 + y;
    }

    class SimpleDelegateExec : AChap10ExecObject
    {
        public override void Exec()
        {
            try
            {
                SimpleDelegateUsage();

                DisplayInfoOfDelegateObject();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in SimpleDelegateExec.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// Simple Delegate Example
        /// </summary>
        private void SimpleDelegateUsage()
        {
            Console.WriteLine("=> Simple Delegate Example: ");

            // Create a BinaryOp delegate object that "points to"
            // SimpleMath.Add()
            BinaryOp b = new BinaryOp(SimpleMath.Add);

            // Invoke Add() method indirectly using delegate object
            Console.WriteLine("10 + 10 is {0}", b(10, 10));

            Console.WriteLine();
        }

        private static void DisplayDelegateInfo(Delegate delObj)
        {
            // Print the names of each member 
            // in the delegate's invocation list
            foreach (Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine("Method Name: {0}", d.Method);
                Console.WriteLine("Type Name: {0}", d.Target);
            }
        }

        /// <summary>
        /// Display info of delegate object
        /// </summary>
        private void DisplayInfoOfDelegateObject()
        {
            Console.WriteLine("=> Display info of delegate object: ");

            // Create a delegate using object's static method
            BinaryOp b = new BinaryOp(SimpleMath.Subtract);
            DisplayDelegateInfo(b);

            // Create a delegate using object's instance method
            SimpleMath m = new SimpleMath();
            b = new BinaryOp(m.InstanceMethod);
            DisplayDelegateInfo(b);

            Console.WriteLine();
        }
    }
}
