using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap8.icomparableinterface
{
    class CustomPropertyAndSortTypesComparableCar : IComparable
    {
        public const int MaxSpeed = 100;

        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";
        public int CarID { get; set; }

        // Property to return the PetNameComparer
        public static IComparer SortByPetName
        {
            get { return (IComparer)new PetNameComparer(); }
        }

        public CustomPropertyAndSortTypesComparableCar() {}

        public CustomPropertyAndSortTypesComparableCar(string name, int speed)
        {
            PetName = name;
            CurrentSpeed = speed;
        }

        public CustomPropertyAndSortTypesComparableCar(string name, int speed, int id)
        {
            PetName = name;
            CurrentSpeed = speed;
            CarID = id;
        }

        /// <summary>
        /// IComparable Implementation
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        int IComparable.CompareTo(object obj)
        {
            if (obj is ComparableCar temp)
            {
                //if (this.CarID > temp.CarID)
                //    return 1;

                //if (this.CarID < temp.CarID)
                //    return -1;
                //else
                //    return 0;
                return this.CarID.CompareTo(temp.CarID);
            }
            else
                throw new ArgumentNullException("Parameter is not a Car!");
        }
    }
}
