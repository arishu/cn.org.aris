using CoreCSharpPrograming.chap8.definecustominterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap8.interfaceimplementation
{
    public class PitchFork : ICloneable, IPointy
    {
        public byte Points => throw new NotImplementedException();

        public byte OtherPoints { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public byte GetNumberOfPoints()
        {
            throw new NotImplementedException();
        }
    }
}
