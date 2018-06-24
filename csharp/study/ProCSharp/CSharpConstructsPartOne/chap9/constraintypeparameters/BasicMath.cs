using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap9.constraintypeparameters
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BasicMath<T> where T : IEnumerable
    {
        //public T Add (T arg1, T arg2) => (arg1 + arg2);

        //public T Subtract(T arg1, T arg2) => (arg1 - arg2);

        //public T Multiply(T arg1, T arg2) => (arg1 * arg2);

        //public T Dvide(T arg1, T arg2) => (arg1 / arg2);
    }
}
