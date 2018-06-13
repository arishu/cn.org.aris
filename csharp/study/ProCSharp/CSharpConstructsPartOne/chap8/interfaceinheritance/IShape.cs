using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap8.interfaceinheritance
{
    interface IShape : IDrawable, IPrintable
    {
        int GetNumberOfSides();
    }
}
