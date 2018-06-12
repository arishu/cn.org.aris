using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap8.interfaceimplementation
{
    abstract class Shape
    {
        // Every derived class must now support this method!
        public abstract byte GetNumberOfPoints();

        public string PetName { get; set; }

        public Shape(string name = "NoName")
        {
            PetName = name;
        }

        /// <summary>
        /// A single virtual method
        /// </summary>
        public virtual void Draw()
        {
            Console.WriteLine("Inside Shape.Draw()");
        }
    }
}
