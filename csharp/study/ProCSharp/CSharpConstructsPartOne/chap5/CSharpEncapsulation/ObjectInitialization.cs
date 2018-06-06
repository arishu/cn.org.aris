using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap5.CSharpEncapsulation
{
    class ObjectInitialization : AChap5ExecObject
    {
        public override void Exec()
        {
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in CSharpEncapsulationServices: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        private void NormalObjectInitialization()
        {
            Console.WriteLine("=> Normal Object Initialization: ");

            // Make a Point by setting each property manually
            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStats();

            // Make a Point via a custom constructor
            Point anotherPoint = new Point(20, 20);
            anotherPoint.DisplayStats();

            // Make a Point using object init syntax
            Point finalPoint = new Point { X = 30, Y = 30 };
            finalPoint.DisplayStats();

            Console.WriteLine();
        }

        /// <summary>
        /// Calling Custom Constructor With Initialization Syntax
        /// </summary>
        private void CustomConstructorWithInitializationSyntax()
        {
            Console.WriteLine("=> Calling Custom Constructor With Initialization Syntax: ");

            PointForInitializationSyntax point =
                new PointForInitializationSyntax(PointColor.Gold) { X = 90, Y = 20 };
            point.DisplayStats();

            Console.WriteLine();
        }

        /// <summary>
        /// Initializing Data With Initialization Syntax
        /// </summary>
        private void DataInitializationWithInitializationSyntax()
        {
            Console.WriteLine("=> Initializing Data With Initialization Syntax: ");

            Rectangle myRect = new Rectangle
            {
                TopLeft = new PointForInitializationSyntax { X = 10, Y = 20 },
                BottomRight = new PointForInitializationSyntax { X = 200, Y = 200 }
            };

            Console.WriteLine();
        }
    }
}
