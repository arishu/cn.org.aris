using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap9.customgenericstructuresandclasses
{
    public struct Point<T>
    {
        // Generic state
        private T xPos;
        private T yPos;

        // Generic Constructor
        public Point(T xVal, T yVal)
        {
            xPos = xVal;
            yPos = yVal;
        }

        // Generic Properties
        public T X
        {
            get { return xPos; }
            set { xPos = value; }
        }
        public T Y
        {
            get { return yPos; }
            set { yPos = value; }
        }

        public override string ToString() => $"[{xPos}, {yPos}]";

        // Reset fields to the default value of the
        // type parameter
        public void ResetPoint()
        {
            xPos = default(T);
            yPos = default(T);
        }
    }
}
