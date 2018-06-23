using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap9.customgenericmethods
{
    class CustomGenericMethodExec : AChap9ExecObject
    {
        public override void Exec()
        {
            try
            {
                CustomGenericMethodUsage();

                GetBaseClassOfTypeParameter();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in CustomGenericMethodExec.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// Generic method for swap two value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine("You sent the Swap() method a {0}", typeof(T));
            T temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// Custom Generic Method Usage
        /// </summary>
        private void CustomGenericMethodUsage()
        {
            Console.WriteLine("=> Custom Generic Method Usage: ");

            // Swap 2 ints
            int a = 10, b = 90;
            Console.WriteLine("Before swap: {0}, {1}", a, b);
            Swap<int>(ref a, ref b);
            Console.WriteLine("After swap: {0}, {1}", a, b);

            // Swap 2 strings
            string s1 = "Hello", s2 = "There";
            Console.WriteLine("Before swap: {0}, {1}", s1, s2);
            Swap<string>(ref s1, ref s2);
            Console.WriteLine("After swap: {0}, {1}", s1, s2);

            Console.WriteLine();
        }

        static void DisplayBaseClass<T>()
        {
            Console.WriteLine("Base class of {0} is: {1}", typeof(T), typeof(T).BaseType);
        }

        /// <summary>
        /// Base class of type parameter
        /// </summary>
        private void GetBaseClassOfTypeParameter()
        {
            Console.WriteLine("=> Base class of type parameter: ");

            DisplayBaseClass<int>();
            DisplayBaseClass<string>();

            Console.WriteLine();
        }
    }
}
