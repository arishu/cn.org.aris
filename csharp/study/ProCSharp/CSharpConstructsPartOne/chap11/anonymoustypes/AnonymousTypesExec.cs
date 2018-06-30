using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap11.anonymoustypes
{
    class AnonymousTypesExec : AChap11ExecObject
    {
        public override void Exec()
        {
            try
            {
                AnonymousTypeUsage();

                InternalRepresentationOfAnonymousType();

                AnonymousEqualityTest();

                AnonymousTypeContainingAnonymousType();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in AnonymousTypesExec.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        static void BuildAnonType(string make, string color, int currSp)
        {
            // Build an anonymous type using incoming args
            var car = new { Make = make, Color = color, Speed = currSp };

            // Now you can using this type to get the property data
            Console.WriteLine("You hava a {0} {1} going {2} MPH", car.Color, car.Make, car.Speed);

            // Annonymous types have custom implementations 
            Console.WriteLine("ToString() == {0}", car.ToString());
        }

        /// <summary>
        /// Anounymous Type Usage
        /// </summary>
        private void AnonymousTypeUsage()
        {
            Console.WriteLine("=> Anounymous Type Usage: ");

            // Make an anonymous type representing a car
            var myCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };

            // Now, show the color and make
            Console.WriteLine("My Car is a {0} {1}.", myCar.Color, myCar.Make);

            // Now, call our helper method to build anonymous type via args
            BuildAnonType("BMW", "Black", 90);

            Console.WriteLine();
        }

        static void ReflectOverAnonymousType(object obj)
        {
            Console.WriteLine("obj is an instance of: {0}", obj.GetType().Name);
            Console.WriteLine("Base class of {0} is {1}", obj.GetType().Name, obj.GetType().BaseType);
            Console.WriteLine("obj.ToString() == {0}", obj.ToString());
            Console.WriteLine("obj.GetHashCode() == {0}", obj.GetHashCode());
        }

        /// <summary>
        /// Internal Representation of Anonymous Type
        /// </summary>
        private void InternalRepresentationOfAnonymousType()
        {
            Console.WriteLine("=> Internal Representation of Anonymous Type: ");

            // Make an anonymous type representing 
            var myCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };

            // Reflect over what the compiler generated
            ReflectOverAnonymousType(myCar);

            Console.WriteLine();
        }

        /// <summary>
        /// Equality of Anonymous Type
        /// </summary>
        private void AnonymousEqualityTest()
        {
            Console.WriteLine("=> Equality of Anonymous Type: ");

            // Make 2 anonymous classes with identical name/value pairs.
            var firstCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };
            var secondCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };

            // Are they considered equal when using Equals()?
            if (firstCar.Equals(secondCar))
                Console.WriteLine("Same anonymous object!");
            else
                Console.WriteLine("Not the same anonymous object!");

            // Are they considered equal when using ==?
            if (firstCar == secondCar)
                Console.WriteLine("Same anonymous object!");
            else
                Console.WriteLine("Not the same anonymous object!");

            // Are these objects the same underlying type?
            if (firstCar.GetType().Name == secondCar.GetType().Name)
                Console.WriteLine("We are both the same type!");
            else
                Console.WriteLine("We are different types!");


            // Show all the details.
            Console.WriteLine();
            ReflectOverAnonymousType(firstCar);
            ReflectOverAnonymousType(secondCar);
        }

        /// <summary>
        /// Anonymous Type Containing Anonymous Type
        /// </summary>
        private void AnonymousTypeContainingAnonymousType()
        {
            Console.WriteLine("=> Anonymous Type Containing Anonymous Type: ");

            // Make an anonymous type that is composed of another.
            var purchaseItem = new
            {
                TimeBought = DateTime.Now,
                ItemBought = new { Color = "Red", Make = "Saab", CurrentSpeed = 55 },
                Price = 34.000
            };
            ReflectOverAnonymousType(purchaseItem);

            Console.WriteLine();
        }
    }
}
