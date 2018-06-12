using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap8.explicitinterfaceimplementation
{
    class OctagonWithSingleImplementationMethod : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        public void Draw()
        {
            Console.WriteLine("Drawing the Octa");
        }
    }
}
