using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap5.thiskeywordusage
{
    class MotorcycleWithOptionalArgumentsConstructor
    {
        private int _driverIntensity;
        private string _driverName;

        public int DriverIntensity { get; set; }
        public string DriverName { get; set; }

        /// <summary>
        /// Constructor with optional arguments
        /// </summary>
        /// <param name="intensity"></param>
        /// <param name="name"></param>
        public MotorcycleWithOptionalArgumentsConstructor(int intensity = 10, string name = "")
        {
            Console.WriteLine("In Ctor with Optional Arguments");

            if (intensity > 10)
                intensity = 10;
            DriverIntensity = intensity;
            DriverName = name;
        }
    }
}
