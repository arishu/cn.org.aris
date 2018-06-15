using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap8.icloneableinterface
{
    class ICloneableInterfaceUsageExec : AChap8ExecObject
    {
        public override void Exec()
        {
            try
            {
                ReferenceToSameObject();

                ObjectCloneUsage();

                ElaborateCloneableObjectUsage();

                DeepObjectCopy();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in ICloneableInterfaceUsageExec.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// Refer to Same Object on the heap
        /// </summary>
        private void ReferenceToSameObject()
        {
            Console.WriteLine("=> Refer to Same Object on the heap: ");

            Point p1 = new Point(50, 50);
            Console.WriteLine(p1);

            Point p2 = p1;
            p2.X = 0;
            Console.WriteLine(p1);

            Console.WriteLine();
        }

        /// <summary>
        /// Object Clone Usage
        /// </summary>
        private void ObjectCloneUsage()
        {
            Console.WriteLine("=> Object Clone Usage: ");

            CloneablePoint p3 = new CloneablePoint(100, 100);
            Console.WriteLine(p3);

            CloneablePoint p4 = (CloneablePoint)p3.Clone();
            Console.WriteLine(p4);

            p4.X = 0;
            Console.WriteLine($"p3.X = {p3.X}");
            Console.WriteLine($"p4.X = {p3.X}");

            Console.WriteLine();
        }

        /// <summary>
        /// Elaborate Cloneable Object Usage
        /// </summary>
        private void ElaborateCloneableObjectUsage()
        {
            Console.WriteLine("=> Elaborate Cloneable Object Usage: ");

            Console.WriteLine("Cloned p3 and stored new Point in p4");
            ElaborateCloneablePoint p3 = new ElaborateCloneablePoint(100, 100, "Jane");
            ElaborateCloneablePoint p4 = (ElaborateCloneablePoint)p3.Clone();
            Console.WriteLine("Before modification:");
            Console.WriteLine("p3: {0}", p3);
            Console.WriteLine("p4: {0}", p4);

            p4.desc.PetName = "My new Point";
            p4.X = 9;

            Console.WriteLine("\nChanged p4.desc.petName and p4.X");
            Console.WriteLine("After modification:");
            Console.WriteLine("p3: {0}", p3);
            Console.WriteLine("p4: {0}", p4);

            Console.WriteLine();
        }

        /// <summary>
        /// Deep Object Copy
        /// </summary>
        private void DeepObjectCopy()
        {
            Console.WriteLine("=> Deep Object Copy: ");

            DeepCloneablePoint p3 = new DeepCloneablePoint(100, 100, "Jane");
            DeepCloneablePoint p4 = (DeepCloneablePoint)p3.Clone();
            Console.WriteLine("Before modification:");
            Console.WriteLine("p3: {0}", p3);
            Console.WriteLine("p4: {0}", p4);

            p4.desc.PetName = "My new Point";
            p4.X = 9;

            Console.WriteLine("\nChanged p4.desc.petName and p4.X");
            Console.WriteLine("After modification:");
            Console.WriteLine("p3: {0}", p3);
            Console.WriteLine("p4: {0}", p4);

            Console.WriteLine();
        }
    }
}
