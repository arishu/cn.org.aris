using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap8.interfaceinheritance
{
    class InterfaceInheritanceExec : AChap8ExecObject
    {
        public override void Exec()
        {
            try
            {
                SimpleInterfaceInheritance();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in InterfaceInheritanceExec.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// Simple Interface Inheritance
        /// </summary>
        private void SimpleInterfaceInheritance()
        {
            Console.WriteLine("=> Simple Interface Inheritance: ");

            // Call from object level
            BitmapImage myBitmap = new BitmapImage();
            myBitmap.Draw();
            myBitmap.DrawInBoundingBox(10, 10, 100, 150);
            myBitmap.DrawUpsideDown();

            if (myBitmap is IAdvancedDraw iAdvDraw)
                iAdvDraw.DrawUpsideDown();

            Console.WriteLine();
        }
    }
}
