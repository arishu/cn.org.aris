using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap6.polymorphic
{
    /// <summary>
    /// The Abstract Base class of the hierarchy
    /// </summary>
    abstract class Shape
    {
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
