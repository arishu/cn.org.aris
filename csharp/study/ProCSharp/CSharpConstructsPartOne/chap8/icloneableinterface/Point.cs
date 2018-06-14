using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap8.icloneableinterface
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point() { }
        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }

        public override string ToString() => $"X = {X}; Y = {Y}";
    }
}
