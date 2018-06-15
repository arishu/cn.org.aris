using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap8.icomparableinterface
{
    class IComparableInterfaceExec : AChap8ExecObject
    {
        public override void Exec()
        {
            try
            {
                ComparableInterfaceUsage();

                CompareUsingCustomComparer();

                CompareUsingComparableInterfaceWithCustomPropertyAndSortTypes();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in IComparableInterfaceExec.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// Comparable Interface Usage
        /// </summary>
        private void ComparableInterfaceUsage()
        {
            Console.WriteLine("=> Comparable Interface Usage: ");

            NormalCar[] myAutos = new NormalCar[5];
            myAutos[0] = new NormalCar("Rusty", 80, 1);
            myAutos[1] = new NormalCar("Mary", 40, 234);
            myAutos[2] = new NormalCar("Viper", 40, 34);
            myAutos[3] = new NormalCar("Mel", 40, 4);
            myAutos[4] = new NormalCar("Chucky", 40, 5);

            // Display current array
            foreach (NormalCar c in myAutos)
            {
                Console.WriteLine("{0}: {1}", c.CarID, c.PetName);
            }

            // Now, sort them using IComparable
            Array.Sort(myAutos);
            Console.WriteLine();

            // Display sorted array
            Console.WriteLine("Here is the ordered set of cars: ");
            foreach (NormalCar c in myAutos)
            {
                Console.WriteLine("{0}: {1}", c.CarID, c.PetName);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Compare Using Custom Comparer
        /// </summary>
        private void CompareUsingCustomComparer()
        {
            Console.WriteLine("=> Compare Using Custom Comparer: ");

            NormalCar[] myAutos = new NormalCar[5];
            myAutos[0] = new NormalCar("Rusty", 80, 1);
            myAutos[1] = new NormalCar("Mary", 40, 234);
            myAutos[2] = new NormalCar("Viper", 40, 34);
            myAutos[3] = new NormalCar("Mel", 40, 4);
            myAutos[4] = new NormalCar("Chucky", 40, 5);

            // Display current array
            foreach (NormalCar c in myAutos)
            {
                Console.WriteLine("{0}: {1}", c.CarID, c.PetName);
            }

            // Now, sort by pet name
            Array.Sort(myAutos, new PetNameComparer());

            // Dump sorted array
            Console.WriteLine("Order by pet name:");
            foreach (NormalCar c in myAutos)
            {
                Console.WriteLine("{0}: {1}", c.CarID, c.PetName);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Compare Using Comparable Interface With Custom Property And SortTypes
        /// </summary>
        private void CompareUsingComparableInterfaceWithCustomPropertyAndSortTypes()
        {
            Console.WriteLine("=> Compare Using Comparable Interface " +
                "With Custom Property And SortTypes: ");

            NormalCar[] myAutos = new NormalCar[5];
            myAutos[0] = new NormalCar("Rusty", 80, 1);
            myAutos[1] = new NormalCar("Mary", 40, 234);
            myAutos[2] = new NormalCar("Viper", 40, 34);
            myAutos[3] = new NormalCar("Mel", 40, 4);
            myAutos[4] = new NormalCar("Chucky", 40, 5);

            // Display current array
            foreach (NormalCar c in myAutos)
            {
                Console.WriteLine("{0}: {1}", c.CarID, c.PetName);
            }

            // Now, sort by pet name
            Array.Sort(myAutos, CustomPropertyAndSortTypesComparableCar.SortByPetName);

            // Dump sorted array
            Console.WriteLine("Order by pet name:");
            foreach (NormalCar c in myAutos)
            {
                Console.WriteLine("{0}: {1}", c.CarID, c.PetName);
            }

            Console.WriteLine();

            Console.WriteLine();
        }
    }
}
