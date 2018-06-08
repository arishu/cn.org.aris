using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap6.polymorphic
{
    class CircleWithInterface : ShapeWithInterface
    {
        public CircleWithInterface() { }

        public CircleWithInterface(string name)
            :base(name)
        {
            Console.WriteLine("Circle Constructor with parameter 'name' is called.");
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Circle", PetName);
        }
    }
}
