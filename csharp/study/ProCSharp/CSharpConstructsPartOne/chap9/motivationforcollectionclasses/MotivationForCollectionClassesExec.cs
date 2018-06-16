using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap9.motivationforcollectionclasses
{
    class MotivationForCollectionClassesExec : AChap9ExecObject
    {
        public override void Exec()
        {
            try
            {
                WorkingWithArrayList();


            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in MotivationForCollectionClassesExec.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// Working With ArrayList
        /// </summary>
        private void WorkingWithArrayList()
        {
            Console.WriteLine("=> Working With ArrayList: ");

            ArrayList strArray = new ArrayList();
            strArray.AddRange(new string[] { "First", "Second", "Third"});
            Console.WriteLine("The collection has {0} items.", strArray.Count);
            Console.WriteLine();

            // Add a new item and display current count
            Console.WriteLine("Add a new item");
            strArray.Add("Fourth!");
            Console.WriteLine("Now, The collection has {0} items.", strArray.Count);

            // Display contents
            foreach (string s in strArray)
            {
                Console.WriteLine("Entry: {0}", s);
            }

            Console.WriteLine();
        }
    }
}
