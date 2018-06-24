using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap9.constraintypeparameters
{
    class ConstrainTypeParametersExec : AChap9ExecObject
    {
        public override void Exec()
        {
            try
            {
                ConstrainTypeParametersUsage();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in ConstrainTypeParametersExec.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// Constrain Type Parameters Usage
        /// </summary>
        private void ConstrainTypeParametersUsage()
        {
            Console.WriteLine("=> Constrain Type Parameters Usage: ");

            Console.WriteLine("new() constraint will constrain type parameter must have a default constructor: ");
            Console.WriteLine($"\t: public class MyGenericClass<T> where T : new()");

            Console.WriteLine("Multi Constraints: ");
            Console.WriteLine($"\t: public class MyGenericClass<T> where T : class, IDrawable, new()");

            Console.WriteLine("new() constrain must be listed last, otherwise it will not compile: ");
            Console.WriteLine($"\t: public class MyGenericClass<T> where T : new(), class, IDrawable");

            Console.WriteLine("constrain each type parameter using keyword [where]");
            Console.WriteLine($"\t: public class MyGenericClass<K, T> where K : SomeBaseClass, new() where T : struct, IComparable<T>");

            Console.WriteLine();
        }

        /// <summary>
        /// Operator Constrains
        /// </summary>
        private void OperatorConstrains()
        {
            Console.WriteLine("=> Lock of Operator Constrains: ");

            Console.WriteLine();
        }
    }
}
