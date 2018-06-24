using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap9.customgenericstructuresandclasses
{
    class CustomGenericStrutureAndClassExec : AChap9ExecObject
    {
        public override void Exec()
        {
            try
            {
                CustomGenericStrutureAndClassUsage();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in CustomGenericStrutureAndClassExec.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// Custom Generic Struture And Class Usage
        /// </summary>
        private void CustomGenericStrutureAndClassUsage()
        {
            Console.WriteLine("=> Custom Generic Struture And Class Usage:");

            // Point using ints
            Point<int> p = new Point<int>(10, 10);
            Console.WriteLine("p.ToString()={0}", p.ToString());
            p.ResetPoint();
            Console.WriteLine("p.ToString()={0}", p.ToString());
            Console.WriteLine();

            // Point using double
            Point<double> p2 = new Point<double>(5.4, 3.3);
            Console.WriteLine("p2.ToString()={0}", p2.ToString());
            p2.ResetPoint();
            Console.WriteLine("p2.ToString()={0}", p2.ToString());

            Console.WriteLine();
        }
    }
}
