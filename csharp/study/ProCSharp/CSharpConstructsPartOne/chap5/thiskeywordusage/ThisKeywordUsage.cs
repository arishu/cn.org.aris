using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap5.thiskeywordusage
{
    class ThisKeywordUsage : AChap5ExecObject
    {
        public override void Exec()
        {
            ChainingConstructorCallingUsingThis();


        }

        /// <summary>
        /// Chaining Constructor Calling Using This Keyword
        /// </summary>
        private void ChainingConstructorCallingUsingThis()
        {
            Console.WriteLine("=> Chaining Constructor Calling Using This Keyword:");

            MotorcycleWithChaingConstructorCalling c = new MotorcycleWithChaingConstructorCalling(5)
            {
                DriverName = "Tiny"
            };
            Console.WriteLine("Rider name is {0}", c.DriverName);

            Console.WriteLine();
        }

        /// <summary>
        /// Constructor with Optional Arguments
        /// </summary>
        private void OptionalArgumentsConstructor()
        {
            Console.WriteLine("=> Optional Arguments Construtor: ");

            // driverName = "", driverIntensity = 0
            MotorcycleWithOptionalArgumentsConstructor m1 = 
                new MotorcycleWithOptionalArgumentsConstructor();
            Console.WriteLine("Name= {0}, Intensity= {1}",
            m1.DriverName, m1.DriverIntensity);

            // driverName = "Tiny", driverIntensity = 0
            MotorcycleWithOptionalArgumentsConstructor m2 = 
                new MotorcycleWithOptionalArgumentsConstructor(name: "Tiny");
            Console.WriteLine("Name= {0}, Intensity= {1}",
            m2.DriverName, m2.DriverIntensity);

            // driverName = "", driverIntensity = 7
            MotorcycleWithOptionalArgumentsConstructor m3 = 
                new MotorcycleWithOptionalArgumentsConstructor(7);
            Console.WriteLine("Name= {0}, Intensity= {1}",
            m3.DriverName, m3.DriverIntensity);

            Console.WriteLine();
        }
    }
}
