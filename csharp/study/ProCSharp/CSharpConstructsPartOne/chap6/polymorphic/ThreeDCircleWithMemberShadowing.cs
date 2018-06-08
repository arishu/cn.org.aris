using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap6.polymorphic
{
    class ThreeDCircleWithMemberShadowing : CircleWithInterface
    {
        // Hide PetName property above me
        public new string PetName { get; set; }

        // Hide any draw() implementation above me
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D Circle.");
        }
    }
}
