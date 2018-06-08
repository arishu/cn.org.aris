using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap6.polymorphic
{
    class Circle : Shape
    {
        public Circle() { }

        public Circle(string name)
            :base(name)
        {
            Console.WriteLine("Circle Constructor with parameter 'name' is called.");
        }
    }
}
