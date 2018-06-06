using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap5.CSharpEncapsulation
{
    class GarageInitializedInConstructor
    {
        // The hidden int backing field is set to zero
        public int NumberOfCars { get; set; }

        // The hidden Car backing field is set to null 
        public Car MyAuto { get; set; }

        // Must use constructors to override default
        // values assigned to hidden backing field
        public GarageInitializedInConstructor()
        {
            MyAuto = new Car();
            NumberOfCars = 1;
        }

        public GarageInitializedInConstructor(Car car, int number)
        {
            MyAuto = car;
            NumberOfCars = number;
        }
    }
}
