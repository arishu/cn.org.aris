using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap10.lambdaexpressions
{
    public class SimpleMath
    {
        public delegate string VerySimpleDelegate();

        public delegate void MathMessage(string msg, int result);
        private MathMessage mmDelegate;

        public void SetMathHandler(MathMessage target)
        {
            mmDelegate = target;
        }

        public void Add(int x, int y)
        {
            mmDelegate?.Invoke("Add has completed!", x + y);
        }
    }
}
