using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static CoreCSharpPrograming.chap10.eventkeyword.CarWithGenericEventHandler;

namespace CoreCSharpPrograming.chap10.eventkeyword
{
    class EventUsageExec : AChap10ExecObject
    {
        public override void Exec()
        {
            try
            {
                BasicEventUsage();

                SimplifiedBasicEventUsage();

                CustomEventArgumentsUsage();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in EventUsageExec.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }


        static void CarAboutToBlow(string msg)
        {
            Console.WriteLine(msg);
        }

        static void CarIsAlmostDoomed(string msg)
        {
            Console.WriteLine("=> Critical Message from Car: {0}", msg);
        }

        static void CarExploded(string msg)
        {
            Console.WriteLine(msg);
        }

        /// <summary>
        /// Basic Event Usage
        /// </summary>
        private void BasicEventUsage()
        {
            Console.WriteLine("=> Basic Event Usage: ");

            Car c1 = new Car("SlugBug", 100, 10);

            // Register event handlers
            c1.AboutToBlow += new Car.CarEngineHandler(CarIsAlmostDoomed);
            c1.AboutToBlow += new Car.CarEngineHandler(CarIsAlmostDoomed);

            Car.CarEngineHandler d = new Car.CarEngineHandler(CarExploded);
            c1.Exploded += d;

            Console.WriteLine("Speed Up");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            // Remove CarExploded method from invocation list
            c1.Exploded -= d;

            Console.WriteLine("Speed Up");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Simplified Basic Event Usage
        /// </summary>
        private void SimplifiedBasicEventUsage()
        {
            Console.WriteLine("=> Simplified Basic Event Usage: ");

            Car c1 = new Car("SlugBug", 100, 10);

            // Register event handlers
            c1.AboutToBlow += CarIsAlmostDoomed;
            c1.AboutToBlow += CarIsAlmostDoomed;
            c1.Exploded += CarExploded;

            Console.WriteLine("Speed Up");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            // Remove CarExploded method from invocation list
            c1.Exploded -= CarExploded;

            Console.WriteLine("Speed Up");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            Console.WriteLine();
        }

        static void HookIntoEvents()
        {
            Car newCar = new Car();
            newCar.AboutToBlow += NewCar_AboutToBlow;
        }

        private static void NewCar_AboutToBlow(string msg)
        {
            Console.WriteLine("This is new car: {0}", msg);
        }

        static void CarAboutToBlow(object sender, CarEventArgs e)
        {
           if (sender is CarWithEventArgs c)
            {
                Console.WriteLine("{0} says: Critical Message from {1}: {2}", sender, c.PetName, e.msg);
            }
        }

        static void CarIsAlmostDoomed(object sender, CarEventArgs e)
        {
            Console.WriteLine("=> Critical Message from Car: {0}", e.msg);
        }

        static void CarExploded(object sender, CarEventArgs e)
        {
            Console.WriteLine(e.msg);
        }

        /// <summary>
        /// Creating Custom Event Arguments
        /// </summary>
        private void CustomEventArgumentsUsage()
        {
            Console.WriteLine("=> Creating Custom Event Arguments");

            CarWithEventArgs c1 = new CarWithEventArgs("SlugBug", 100, 10);

            // Register event handlers
            c1.AboutToBlow += CarIsAlmostDoomed;
            c1.AboutToBlow += CarIsAlmostDoomed;
            c1.Exploded += CarExploded;

            Console.WriteLine("Speed Up");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            // Remove CarExploded method from invocation list
            c1.Exploded -= CarExploded;

            Console.WriteLine("Speed Up");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Generic Event Handler Delegate Usage
        /// </summary>
        private void GenericEventHandlerDelegateUsage()
        {
            Console.WriteLine("=> Generic Event Handler Delegate Usage: ");

            CarWithGenericEventHandler c1 = new CarWithGenericEventHandler("SlugBug", 100, 10);

            // Register event handlers
            c1.AboutToBlow += CarIsAlmostDoomed;
            c1.AboutToBlow += CarAboutToBlow;

            CarEngineHandler<CarEventArgs> d = new CarEngineHandler<CarEventArgs>(CarExploded);
            c1.Exploded += d;

            Console.WriteLine("Speed Up");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            // Remove CarExploded method from invocation list
            c1.Exploded -= CarExploded;

            Console.WriteLine("Speed Up");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            Console.WriteLine();
        }
    }
}
