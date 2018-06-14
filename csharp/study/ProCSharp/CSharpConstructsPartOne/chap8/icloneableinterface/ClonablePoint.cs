using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap8.icloneableinterface
{
    public class ClonablePoint : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public ClonablePoint() { }
        public ClonablePoint(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }

        // Override Object.ToString()
        public override string ToString() => $"X = {X}; Y = {Y}";

        // Return a copy of the current object
        public object Clone() => new Point(this.X, this.Y);
    }
}
