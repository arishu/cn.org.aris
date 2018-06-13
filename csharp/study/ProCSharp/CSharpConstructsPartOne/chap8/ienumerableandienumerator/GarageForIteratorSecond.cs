using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap8.ienumerableandienumerator
{
    public class GarageForIteratorSecond : IEnumerable
    {
        private Car[] carArray = new Car[4];

        public GarageForIteratorSecond()
        {
            carArray[0] = new Car("FeeFee", 200);
            carArray[1] = new Car("Clunker", 90);
            carArray[2] = new Car("Zippy", 30);
            carArray[3] = new Car("Fred", 30);
        }

        // Iterator method
        public IEnumerator GetEnumerator()
        {
            // throw new Exception("This won't get called");
            return actualImplementation();

            IEnumerator actualImplementation()
            {
                foreach (Car c in carArray)
                {
                    yield return c;
                }
            }
        }
    }
}
