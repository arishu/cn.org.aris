using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap8.icloneableinterface
{
    public class CloneablePoint : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public CloneablePoint() { }
        public CloneablePoint(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }

        // Override Object.ToString()
        public override string ToString() => $"X = {X}; Y = {Y}";

        // Return a copy of the current object
        public object Clone() => new CloneablePoint(this.X, this.Y);
    }
}
