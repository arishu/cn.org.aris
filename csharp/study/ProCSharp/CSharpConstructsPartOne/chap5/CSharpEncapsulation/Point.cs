using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap5.CSharpEncapsulation
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point() { }

        public Point(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
        }

        public void DisplayStats()
        {
            Console.WriteLine("[{0}, {1}]", X, Y);
        }
    }
}
