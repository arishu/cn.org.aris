using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap8.ienumerableandienumerator
{
    class IEnumerableAndIEnumeratorInterfaceUsage : AChap8ExecObject
    {
        public override void Exec()
        {
            try
            {
                IEnumeratorUsedManaually();

                IEnumeratorWithForeach();

                BuildIteratorMethodWithYieldKeyword();

                LocalFunctionUsage();

                NamedIteratorUsage();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in IEnumerableAndIEnumeratorInterfaceUsage.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// Manually work with IEnumerator
        /// </summary>
        private void IEnumeratorUsedManaually()
        {
            Console.WriteLine("=> Manually work with IEnumerator: ");

            Garage carLot = new Garage();
            IEnumerator ienum = carLot.GetEnumerator();

            ienum.MoveNext();

            Car myCar = (Car)ienum.Current;

            Console.WriteLine("{0} is going {1} MPH", myCar.PetName, myCar.CurrentSpeed);

            Console.WriteLine();
        }

        /// <summary>
        /// IEnumerator work with Foreach Statement
        /// </summary>
        private void IEnumeratorWithForeach()
        {
            Console.WriteLine("=> IEnumerator work with Foreach Statement: ");

            SecondGarage carLot = new SecondGarage();
            foreach (Car car in carLot)
            {
                Console.WriteLine("{0} is going {1} MPH", car.PetName, car.CurrentSpeed);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Building Iterator Method with yield keyword
        /// </summary>
        private void BuildIteratorMethodWithYieldKeyword()
        {
            Console.WriteLine("=> Building Iterator Method with yield keyword: ");

            GarageForIterator carLot = new GarageForIterator();
            foreach (Car car in carLot)
            {
                Console.WriteLine("{0} is going {1} MPH", car.PetName, car.CurrentSpeed);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Local Function Usage
        /// </summary>
        private void LocalFunctionUsage()
        {
            Console.WriteLine("=> Local Function Usage: ");

            GarageForIteratorSecond carLot = new GarageForIteratorSecond();
            foreach (Car c in carLot)
            {
                Console.WriteLine("{0} is going {1} MPH", c.PetName, c.CurrentSpeed);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Named Iterator Usage
        /// </summary>
        private void NamedIteratorUsage()
        {
            Console.WriteLine("=> Named Iterator Usage: ");

            GarageForIteratorThird carLot = new GarageForIteratorThird();
            foreach (Car c in carLot)
            {
                Console.WriteLine("{0} is going {1} MPH", c.PetName, c.CurrentSpeed);
            }

            Console.WriteLine();
        }
    }
}
