using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap6.basicinheritance
{
    class BasicInheritanceExec : AChap6ExecObject
    {
        public override void Exec()
        {
            try
            {
                BaseClassDesc();

                BasicInHeritance();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in BasicInheritanceExec: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void BaseClassDesc()
        {
            Console.WriteLine("=> Basic Inheritance's Base class: ");

            Car myCar = new Car(80)
            {
                Speed = 50
            };
            Console.WriteLine("My car is going {0} MPH", myCar.Speed);

            Console.WriteLine();
        }

        /// <summary>
        /// Basic Inheritance
        /// </summary>
        private void BasicInHeritance()
        {
            Console.WriteLine("=> Basic Inheritance: ");

            MiniVan myVan = new MiniVan
            {
                Speed = 10
            };
            Console.WriteLine("My van is going {0} MPH", myVan.Speed);

            Console.WriteLine();
        }
    }
}
