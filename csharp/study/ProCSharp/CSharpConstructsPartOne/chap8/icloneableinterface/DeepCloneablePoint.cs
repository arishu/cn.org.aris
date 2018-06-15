using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap8.icloneableinterface
{
    public class DeepCloneablePoint : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription desc = new PointDescription();

        public DeepCloneablePoint() { }

        public DeepCloneablePoint(int xPos, int yPos, string petName)
        {
            X = xPos;
            Y = yPos;
            desc.PetName = petName;
        }

        public DeepCloneablePoint(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }

        // Override Object.ToString()
        public override string ToString()
            => $"X = {X}; Y = {Y}; Name = {desc.PetName};\nID = {desc.PointID}\n";

        // Return a copy of the current object
        public object Clone()
        {
            // First get a shallow copy
            DeepCloneablePoint newPoint = (DeepCloneablePoint)this.MemberwiseClone();

            // Fill in the gaps
            PointDescription currentDesc = new PointDescription();
            currentDesc.PetName = this.desc.PetName;

            newPoint.desc = currentDesc;
            return newPoint;
        }
    }
}
