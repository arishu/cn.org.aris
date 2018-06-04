using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap5.thiskeywordusage
{
    class MotorcycleWithChaingConstructorCalling
    {
        private int _driverIntensity;
        private string _driverName;

        public int DriverIntensity { get; set; }
        public string DriverName { get; set; }

        /// <summary>
        /// The default no-args constructor
        /// </summary>
        public MotorcycleWithChaingConstructorCalling()
        {
            Console.WriteLine("In Default Ctor");
        }

        /// <summary>
        /// Constructor that accepts a single parameter called intensity
        /// </summary>
        /// <param name="intensity"></param>
        public MotorcycleWithChaingConstructorCalling(int intensity)
            : this(intensity, "")
        {
            Console.WriteLine("In Ctor taking an int");
        }

        /// <summary>
        /// Constructor that accepts a single parameter called name 
        /// </summary>
        /// <param name="name"></param>
        public MotorcycleWithChaingConstructorCalling(string name)
            : this(0, name)
        {
            Console.WriteLine("In Ctor taking a string");
        }

        /// <summary>
        /// This is the 'master' constructor that does all the real work
        /// </summary>
        /// <param name="intensity"></param>
        /// <param name="name"></param>
        public MotorcycleWithChaingConstructorCalling(int intensity, string name)
        {
            Console.WriteLine("In Master Ctor");

            if (intensity > 10)
                intensity = 10;
            DriverIntensity = intensity;
            DriverName = name;
        }
    }
}
