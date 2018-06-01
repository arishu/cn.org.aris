using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.DataTypesNarrowingAndWidening
{
    class DataTypesNarrowingAndWideningExec : ADataTypesNarrowingAndWideningExecObject
    {
        public override void Exec()
        {
            DataTypeWidening();

            DataTypenarrowing();
        }

        /// <summary>
        /// Widening Data type
        /// </summary>
        private void DataTypeWidening()
        {
            Console.WriteLine("=> Data type widening: ");

            short num1 = 9, num2 = 10;
            Console.WriteLine("{0} + {1} = {2}", num1, num2, Add(num1, num2));
            Console.WriteLine();
        }

        /// <summary>
        /// Explicitly using Data type narrowing
        /// </summary>
        private void DataTypenarrowing()
        {
            Console.WriteLine("=> Data type narrowing: ");

            short num1 = 30000, num2 = 30000;
            short answer = (short)Add(num1, num2);

            Console.WriteLine("{0} + {1} = {2}", num1, num2, answer);

            Console.WriteLine();
        }


        static int Add(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Checked Keyword Usage
        /// </summary>
        private void CheckedKeywordUsage()
        {
            byte b1 = 100;
            byte b2 = 250;

            try
            {
                byte sum = checked((byte)Add(b1, b2));
                Console.WriteLine("sum = {0}", sum);

                checked
                {
                    byte sum2 = (byte)Add(b1, b2);
                    Console.WriteLine("sum = {0}", sum2);
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Unchecked Keyword usage
        /// </summary>
        private void UnCheckedKeywordUsage()
        {
            byte b1 = 100;
            byte b2 = 250;

            try
            {
                unchecked
                {
                    byte sum = (byte)Add(b1, b2);
                    Console.WriteLine("sum = {0}", sum);
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
