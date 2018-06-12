using CoreCSharpPrograming.chap8.interfaceimplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap8.interfaceasparametersandreturnvalues
{
    class ThreeDCircle : Circle, IDraw3D
    {
        public void Draw3D()
        {
            Console.WriteLine("Drawing Circle in 3D!");
        }
    }
}
