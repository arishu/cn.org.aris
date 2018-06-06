using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap5.CSharpEncapsulation
{
    class MyMathClass
    {
        public const double PI = 3.14;

        // Static Read-Only Field whose value can be known at compile time
        // can be initialized when declared
        public static readonly double COMPILE_TIME_STATIC_READONLY_FIELD = 12.3456;

        // Static Read-Only Field, its value can be known until runtime
        // should be initialized in static constructor
        public static readonly double RUNTIME_STATIC_READONLY_FIELD;

        // Instance Read-Only Field
        public readonly double INSTANCE_READONLY_FIELD;

        static MyMathClass()
        {
            RUNTIME_STATIC_READONLY_FIELD = 23.4567;
        }

        public MyMathClass()
        {
            INSTANCE_READONLY_FIELD = 12.04245;
        }

        //public void InitReadOnlyField()
        //{
        //    READONLY_FIELD = 12.04245;
        //}
    }

    class ConstantFieldData : AChap5ExecObject
    {
        public override void Exec()
        {
            try
            {
                ConstantDataUsage();

                LocalConstStringVariable();

                ReadOnlyFieldUsage();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in CSharpEncapsulationServices: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// Constant Data Usage
        /// </summary>
        private void ConstantDataUsage()
        {
            Console.WriteLine("=> Constant Data Usage: ");

            Console.WriteLine("The value of PI is {0}", MyMathClass.PI);

            // Const Data Can't be changed
            //MyMathClass.PI = 10;
            
            Console.WriteLine();
        }

        /// <summary>
        /// Local Const Data Usage
        /// </summary>
        private void LocalConstStringVariable()
        {
            Console.WriteLine("=> Local Const Data Usage: ");

            const string fixedStr = "Fixed string data";
            Console.WriteLine("Local const string is: {0}", fixedStr);

            Console.WriteLine();
        }

        /// <summary>
        /// Read-Only Field Usage
        /// </summary>
        private void ReadOnlyFieldUsage()
        {
            Console.WriteLine("=> Read-Only Field Usage: ");

            Console.WriteLine("Instance Read-Only field is {0}", 
                new MyMathClass().INSTANCE_READONLY_FIELD);

            Console.WriteLine("Compile Time Static Read-Only field is {0}",
                MyMathClass.COMPILE_TIME_STATIC_READONLY_FIELD);

            Console.WriteLine("Runtime Static Read-Only field is {0}",
                MyMathClass.RUNTIME_STATIC_READONLY_FIELD);

            Console.WriteLine();
        }
    }
}
