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

            ClonablePoint p3 = new ClonablePoint(100, 100);
            Console.WriteLine(p3);

            ClonablePoint p4 = (ClonablePoint)p3.Clone();
            Console.WriteLine(p4);

            p4.X = 0;
            Console.WriteLine($"p3.X = {p3.X}");
            Console.WriteLine($"p4.X = {p3.X}");

            Console.WriteLine();
        }
    }
}
