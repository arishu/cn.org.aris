using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap8.icomparableinterface
{
    class PetNameComparer : IComparer
    {
        int IComparer.Compare(object o1, object o2)
        {
            NormalCar t1 = o1 as NormalCar;
            NormalCar t2 = o2 as NormalCar;

            if (t1 != null && t2 != null)
            {
                return string.Compare(t1.PetName, t2.PetName);
            }
            else
            {
                throw new ArgumentNullException("Parameter is not a Car!");
            }
        }
    }
}
