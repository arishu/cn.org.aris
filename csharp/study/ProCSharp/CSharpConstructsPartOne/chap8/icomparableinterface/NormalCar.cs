using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap8.icomparableinterface
{
    class NormalCar : IComparable
    {
        public const int MaxSpeed = 100;

        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";
        public int CarID { get; set; }

        public NormalCar() {}

        public NormalCar(string name, int speed)
        {
            PetName = name;
            CurrentSpeed = speed;
        }

        public NormalCar(string name, int speed, int id)
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
            if (obj is NormalCar temp)
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
