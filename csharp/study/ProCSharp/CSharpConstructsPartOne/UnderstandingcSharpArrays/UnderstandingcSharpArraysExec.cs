using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpConstructsPartOne.UnderstandingcSharpArrays
{
    class UnderstandingcSharpArraysExec : AUnderstandingcSharpArraysExecObject
    {
        public override void Exec()
        {
            
        }

        /// <summary>
        /// Implicit Array Usage
        /// </summary>
        private void DeclareImplicitArrays()
        {
            Console.WriteLine("=> Implicit Array initialization: ");

            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("a is a: {0}", a.ToString());

            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("b is a: {0}", b.ToString());

            var c = new[] { "Hello", null, "world" };
            Console.WriteLine("c is a: {0}", c.ToString());

            Console.WriteLine();
        }

        /// <summary>
        /// Object Array Usage
        /// </summary>
        private void ArrayOfObjects()
        {
            Console.WriteLine("=> Object Array Usage: ");

            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(2018, 5, 31);
            myObjects[3] = "Form & Void";
            foreach (object obj in myObjects)
            {
                Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Rectangle Multidimential Array Usage
        /// </summary>
        private void RectMultidimensionalArray()
        {
            Console.WriteLine("=> Rectangular multidimensional array.");
            // A rectangular MD array.
            int[,] myMatrix;
            myMatrix = new int[3, 4];
            // Populate (3 * 4) array.
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    myMatrix[i, j] = i * j;
            // Print (3 * 4) array.
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write(myMatrix[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Jagged Multidimentinal Array Usage
        /// </summary>
        private void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> Jagged multidimensional array.");
            // A jagged MD array (i.e., an array of arrays).
            // Here we have an array of 5 different arrays.
            int[][] myJagArray = new int[5][];
            // Create the jagged array.
            for (int i = 0; i < myJagArray.Length; i++)
                myJagArray[i] = new int[i + 7];
            // Print each row (remember, each element is defaulted to zero!).
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                    Console.Write(myJagArray[i][j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // Print out elements in the array
        private void PrintArray(int[] myInts)
        {
            for (int i = 0; i < myInts.Length; i++)
                Console.WriteLine("Item {0} is {1}", i, myInts[i]);
        }

        // Get String array
        static string[] GetStringArray()
        {
            string[] theStrings = { "Hello", "from", "GetStringArray" };
            return theStrings;
        }

        /// <summary>
        /// Array as parameter or as return value
        /// </summary>
        private void PassAndReceiveArrays()
        {
            Console.WriteLine("=> Arrays as params and return values.");

            // Pass array as parameter
            int[] ages = { 20, 22, 23, 0 };
            PrintArray(ages);

            // Get array as return value
            string[] strs = GetStringArray();
            foreach (string s in strs)
                Console.WriteLine(s);

            Console.WriteLine();
        }


    }
}
