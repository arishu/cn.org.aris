using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap6.polymorphic
{
    class HexagonWithInterface : ShapeWithInterface
    {
        public HexagonWithInterface() { }

        public HexagonWithInterface(string name)
            :base(name)
        {
            Console.WriteLine("Hexagon Constructor with parameter 'name' is called");
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon", PetName);
        }
    }
}
