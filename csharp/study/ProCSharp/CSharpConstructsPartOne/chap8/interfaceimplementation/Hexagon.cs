﻿using CoreCSharpPrograming.chap8.definecustominterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap8.interfaceimplementation
{
    class Hexagon : Shape, IPointy
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }

        public byte Points
        {
            get { return 6; }
        }

        public byte OtherPoints { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon", PetName);
        }

        public override byte GetNumberOfPoints()
        {
            throw new NotImplementedException();
        }
    }
}
