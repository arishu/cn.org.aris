using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap8.icloneableinterface
{
    public class ElaborateCloneablePoint : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription desc = new PointDescription();

        public ElaborateCloneablePoint(int xPos, int yPos, string petName)
        {
            X = xPos;
            Y = yPos;
            desc.PetName = petName;
        }

        public ElaborateCloneablePoint(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }

        public ElaborateCloneablePoint() {}

        // Override Object.ToString()
        public override string ToString()
            => $"X = {X}; Y = {Y}; Name = {desc.PetName};\nID = {desc.PointID}\n";

        // Return a copy of the current object
        public object Clone() => this.MemberwiseClone();
    }
}
