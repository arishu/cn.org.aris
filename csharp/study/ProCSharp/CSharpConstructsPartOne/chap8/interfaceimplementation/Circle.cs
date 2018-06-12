using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap8.interfaceimplementation
{
    class Circle : Shape
    {
        public Circle() { }

        public Circle(string name)
            :base(name)
        {
            Console.WriteLine("Circle Constructor with parameter 'name' is called.");
        }

        public override byte GetNumberOfPoints()
        {
            throw new NotImplementedException();
        }
    }
}
