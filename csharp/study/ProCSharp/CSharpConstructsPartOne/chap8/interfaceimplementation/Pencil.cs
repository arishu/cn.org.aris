using CoreCSharpPrograming.chap8.definecustominterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap8.interfaceimplementaion
{
    public class Pencil : IPointy
    {
        public byte Points => throw new NotImplementedException();

        public byte OtherPoints { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public byte GetNumberOfPoints()
        {
            throw new NotImplementedException();
        }
    }
}
