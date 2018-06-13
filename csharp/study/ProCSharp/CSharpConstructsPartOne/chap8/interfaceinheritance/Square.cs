using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap8.interfaceinheritance
{
    class Square : IShape
    {
        // Using explicit implementation to handle member name clash.

        void IDrawable.Draw()
        {
            Console.WriteLine("Drawing to screen...");
        }

        void IPrintable.Draw()
        {
            Console.WriteLine("Drawing to printer...");
        }

        public int GetNumberOfSides()
        {
            return 4;
        }

        public void Print()
        {
            Console.WriteLine("Printing...");
        }
    }
}
