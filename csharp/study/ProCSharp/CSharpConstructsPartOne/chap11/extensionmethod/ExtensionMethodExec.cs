using MyExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap11.extensionmethod
{
    class ExtensionMethodExec : AChap11ExecObject
    {
        public override void Exec()
        {
            try
            {
                InvokingExtensionMethod();


            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in ExtensionMethodExec.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// Invoking Extension Method
        /// </summary>
        private void InvokingExtensionMethod()
        {
            Console.WriteLine("=> Invoking Extension Method: ");

            // The int has assumed a new identity
            int myInt = 12345678;
            myInt.DisplayDefiningAssembly();

            // So has the DataSet
            System.Data.DataSet d = new System.Data.DataSet();
            d.DisplayDefiningAssembly();

            // And the SoundPlayer
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            sp.DisplayDefiningAssembly();

            // Use new integer functionality
            Console.WriteLine("Value of mInt: {0}", myInt);
            Console.WriteLine("Reversed digits of myInt: {0}", myInt.ReverseDigits());

            Console.WriteLine();
        }

        /// <summary>
        /// Extending Interface Compatible Types
        /// </summary>
        private void InterfaceExtensions()
        {
            Console.WriteLine("=> Extending Interface Compatible Types: ");

            // System.Array implements IEnumerable
            string[] data = {   "Wow", "this", "is", "sort", "of", "annoying",
                                "but", "in", "a", "weird", "way", "fun!"};
            data.PrintDataAndBeep();
            Console.WriteLine();

            // List<T> implements IEnumerable
            List<int> myInts = new List<int>() { 10, 15, 20 };
            myInts.PrintDataAndBeep();

            Console.WriteLine();
        }
    }
}
