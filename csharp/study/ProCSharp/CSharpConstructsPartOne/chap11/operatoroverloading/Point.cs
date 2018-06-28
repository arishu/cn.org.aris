using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap11.operatoroverloading
{
    class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }

        public override string ToString() => $"[{this.X},{this.Y}]";

        #region Binary Operators Overloading
        // Overloaded operator +
        public static Point operator +(Point p1, Point p2) => new Point(p1.X + p2.X, p1.Y + p2.Y);
        // Overloaded operator -
        public static Point operator -(Point p1, Point p2) => new Point(p1.X - p2.X, p1.Y - p2.Y);

        public static Point operator +(Point p, int change) => new Point(p.X + change, p.Y + change);
        public static Point operator +(int change, Point p) => new Point(p.X + change, p.Y + change);
        #endregion

        #region Unary Operators Overloading
        public static Point operator ++(Point p) => new Point(p.X + 1, p.Y + 1);
        public static Point operator --(Point p) => new Point(p.X - 1, p.Y - 1);
        #endregion

        #region Equality
        // Method1: override Equals() and GetHashCode() methods
        public override bool Equals(object o) => o.ToString() == this.ToString();
        public override int GetHashCode() => this.ToString().GetHashCode();

        // Method2: using == and != operator overloading
        public static bool operator ==(Point p1, Point p2) => p1.Equals(p2);
        public static bool operator !=(Point p1, Point p2) => !p1.Equals(p2);
        #endregion

        #region Comparison Operators Overloading

        public int CompareTo(Point other)
        {
            if (this.X > other.X && this.Y > other.Y)
                return 1;
            if (this.X < other.X && this.Y < other.Y)
                return -1;
            else
                return 0;
        }

        public static bool operator <(Point p1, Point p2) => p1.CompareTo(p2) < 0;
        public static bool operator >(Point p1, Point p2) => p1.CompareTo(p2) > 0;
        public static bool operator <=(Point p1, Point p2) => p1.CompareTo(p2) <= 0;
        public static bool operator >=(Point p1, Point p2) => p1.CompareTo(p2) >= 0;

        #endregion
    }
}
