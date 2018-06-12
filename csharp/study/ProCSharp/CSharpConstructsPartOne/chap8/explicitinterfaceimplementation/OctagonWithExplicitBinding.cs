using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap8.explicitinterfaceimplementation
{
    class OctagonWithExplicitBinding : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        void IDrawToForm.Draw()
        {
            Console.WriteLine("Drawing to form...");
        }

        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Drawing to memory...");
        }

        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Drawing to printer...");
        }
    }
}
