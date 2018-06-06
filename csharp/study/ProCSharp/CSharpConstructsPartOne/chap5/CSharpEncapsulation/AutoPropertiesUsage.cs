using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap5.CSharpEncapsulation
{
    class AutoPropertiesUsage : AChap5ExecObject
    {
        public override void Exec()
        {
            try
            {
                AutomaticPropertiesUsage();

                AutoPropertiesAndDefaultValues();

                AutoPropertiesInitializationInConstructor();

                AutoPropertiesInitializedWhenInDeclaration();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in CSharpEncapsulationServices: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// Automatic Properties Usage
        /// </summary>
        private void AutomaticPropertiesUsage()
        {
            Console.WriteLine("=> Automatic Properties Usage: ");

            Account account = new Account(1_0000_0000D, "Aris");

            Console.WriteLine("Account Details: {0}", account.Details);

            Console.WriteLine();
        }

        /// <summary>
        /// Automatic Properties and Default Values
        /// </summary>
        private void AutoPropertiesAndDefaultValues()
        {
            Console.WriteLine("=> Automatic Properties and Default Values: ");

            GarageWithoutInitialization g = new GarageWithoutInitialization();

            Console.WriteLine("Numbers of Cars: {0}", g.NumberOfCars);

            Console.WriteLine("Car's name is: {0}", g.MyAuto.PetName);

            Console.WriteLine();
        }

        /// <summary>
        /// Auto Properties initialized in constructor
        /// </summary>
        private void AutoPropertiesInitializationInConstructor()
        {
            Console.WriteLine("=> Auto Properties initialized in constructor: ");

            Car c = new Car
            {
                PetName = "Frank",
                Speed = 55,
                Color = "Red"
            };
            c.DisplayStats();

            // Put car in garage
            GarageInitializedInConstructor g =
                new GarageInitializedInConstructor
                {
                    MyAuto = c
                };
            Console.WriteLine("Number of Cars in garage: {0}", g.NumberOfCars);
            Console.WriteLine("Your car is named: {0}", g.MyAuto.PetName);

            Console.WriteLine();
        }

        /// <summary>
        /// Auto Properties initialized when declared
        /// </summary>
        private void AutoPropertiesInitializedWhenInDeclaration()
        {
            Console.WriteLine("=> Auto Properties initialized when declared: ");

            GarageInitializedWhenDeclared g = new GarageInitializedWhenDeclared();
            g.MyAuto.PetName = "Frank";
            g.MyAuto.Speed = 55;
            g.MyAuto.Color = "Red";
            g.MyAuto.DisplayStats();

            Console.WriteLine("Number of Cars in garage: {0}", g.NumberOfCars);
            Console.WriteLine("Your car is named: {0}", g.MyAuto.PetName);

            Console.WriteLine();
        }
    }
}
