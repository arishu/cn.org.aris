using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap8.definecustominterface
{
    public interface IPointy
    {
        // Implicitly public and abstract
        byte GetNumberOfPoints();

        // Read-Only Property
        byte Points { get; }

        byte OtherPoints { get; set; }
    }
}
