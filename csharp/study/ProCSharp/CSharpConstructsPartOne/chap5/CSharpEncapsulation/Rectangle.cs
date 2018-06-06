using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap5.CSharpEncapsulation
{
    class Rectangle
    {
        private PointForInitializationSyntax topLeft = new PointForInitializationSyntax();
        private PointForInitializationSyntax bottomRight = new PointForInitializationSyntax();

        public PointForInitializationSyntax TopLeft
        {
            get => topLeft;
            set => topLeft = value;
        }

        public PointForInitializationSyntax BottomRight
        {
            get => bottomRight;
            set => bottomRight = value;
        }

        public PointColor Color { get; set; }

        public void DisplayStats()
        {
            Console.WriteLine("[TopLeft: {0}, {1}, {2} BottomRight: {3}, {4}, {5}]",
                topLeft.X, topLeft.Y, topLeft.Color,
                bottomRight.X, bottomRight.Y, bottomRight.Color);
        }
    }
}
