using CoreCSharpPrograming.chap8.definecustominterface;
using CoreCSharpPrograming.chap8.interfaceimplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap8.interfaceasparametersandreturnvalues
{
    class Hexagon : Shape, IPointy, IDraw3D
    {
        public byte Points
        {
            get { return 4; }
        }

        public byte OtherPoints { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Draw3D()
        {
            Console.WriteLine("Drawing Hexagon in 3D!");
        }

        public override byte GetNumberOfPoints()
        {
            throw new NotImplementedException();
        }
    }
}
