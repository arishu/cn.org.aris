using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap5.CSharpEncapsulation
{
    class PointForInitializationSyntax
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointColor Color { get; set; }

        public PointForInitializationSyntax(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
            Color = PointColor.Gold;
        }

        public PointForInitializationSyntax(PointColor ptColor)
        {
            Color = ptColor;
        }

        public PointForInitializationSyntax()
            : this(PointColor.BloodRed) { }

        public void DisplayStats()
        {
            Console.WriteLine("[{0}, {1}]", X, Y);
            Console.WriteLine("Point is {0}", Color);
        }
    }
}
