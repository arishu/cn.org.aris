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

        /// <summary>
        /// ArrayList of random objects
        /// </summary>
        private void ArrayListOfRandomObjects()
        {
            Console.WriteLine("=> ArrayList of random objects: ");

            ArrayList allMyObjects = new ArrayList();
            allMyObjects.Add(true);
            allMyObjects.Add(new OperatingSystem(PlatformID.MacOSX, new Version(10, 0)));
            allMyObjects.Add(66);
            allMyObjects.Add(3.14);

            Console.WriteLine();
        }

        /// <summary>
        /// Custom Person Collection
        /// </summary>
        private void UsePersonCollection()
        {
            Console.WriteLine("=> Custom Person Collection: ");

            PersonCollection myPeople = new PersonCollection();
            myPeople.AddPerson(new Person("Homer", "Simpson", 40));
            myPeople.AddPerson(new Person("Marge", "Simpson", 38));
            myPeople.AddPerson(new Person("Lisa", "Simpson", 9));
            myPeople.AddPerson(new Person("Bart", "Simpson", 7));
            myPeople.AddPerson(new Person("Maggie", "Simpson", 2));

            foreach (Person p in myPeople)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();
        }
    }
}
