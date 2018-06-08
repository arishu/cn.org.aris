using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap6.polymorphic
{
    /// <summary>
    /// The Abstract Base class of the hierarchy
    /// </summary>
    abstract class ShapeWithInterface
    {
        public string PetName { get; set; } 

        public ShapeWithInterface(string name = "NoName")
        {
            PetName = name;
        }

        // Force all child classes to define how to be rendered
        public abstract void Draw();
    }
}
