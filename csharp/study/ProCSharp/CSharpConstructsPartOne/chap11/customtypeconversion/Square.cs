using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap11.customtypeconversion
{
    public struct Square
    {
        public int Length { get; set; }
        public Square(int l) : this()
        {
            Length = l;
        }

        public void Draw()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public override string ToString() => $"[Length = {Length}]";

        // Rectangles can be explicitly converted into Squares
        public static explicit operator Square(Rectangle r) => new Square { Length = r.Height };

        // Convert from an integer
        public static explicit operator Square(int v) => new Square { Length = v };

        // Convert to an integer from a Square
        public static explicit operator int(Square s) => s.Length;
    }
}
