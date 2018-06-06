using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap5.CSharpEncapsulation
{
    class GarageInitializedWhenDeclared
    {
        // The hidden int backing field is set to zero
        public int NumberOfCars { get; set; } = 1;

        // The hidden Car backing field is set to null 
        public Car MyAuto { get; set; } = new Car();

        // Must use constructors to override default
        // values assigned to hidden backing field
        public GarageInitializedWhenDeclared() {}

        public GarageInitializedWhenDeclared(Car car, int number)
        {
            MyAuto = car;
            NumberOfCars = number;
        }
    }
}
