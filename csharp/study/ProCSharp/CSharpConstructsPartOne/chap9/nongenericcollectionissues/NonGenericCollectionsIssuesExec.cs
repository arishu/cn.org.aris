using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap9.nongenericcollectionissues
{
    class NonGenericCollectionsIssuesExec : AChap9ExecObject
    {
        public override void Exec()
        {
            try
            {
                SimpleBoxUnboxOperation();

                WorkWithArrayList();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in NonGenericCollectionsIssuesExec.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// Simple Box and Unbox Operation
        /// </summary>
        private void SimpleBoxUnboxOperation()
        {
            Console.WriteLine("=> Simple Box and Unbox Operation: ");

            // Make a Value variable
            int myInt = 25;

            // Box the int into an object reference
            object boxedInt = myInt;

            // unbox in the wrong data type 
            // to trigger runtime exception
            try
            {
                long unboxedInt = (long)boxedInt;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Working with ArrayList: 
        /// </summary>
        private void WorkWithArrayList()
        {
            Console.WriteLine("=> Working with ArrayList: ");

            ArrayList myInts = new ArrayList();
            myInts.Add(10);
            myInts.Add(20);
            myInts.Add(30);

            int pos = (int)myInts[0];

            Console.WriteLine("Value of your int: {0}", pos);

            Console.WriteLine();
        }
    }
}
