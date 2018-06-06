using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap5.CSharpEncapsulation
{
    class GarageWithoutInitialization
    {
        // The hidden int backing field is set to zero
        public int NumberOfCars { get; set; }

        // The hidden Car backing field is set to null 
        public Car MyAuto { get; set; }
    }
}
