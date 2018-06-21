using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap9.nongenericcollectionissues
{
    public class IntCollection : IEnumerable
    {
        private ArrayList arInts = new ArrayList();

        // Get an int (performs unboxing!).
        public int GetInt(int pos) => (int)arInts[pos];

        // Insert an int (performs boxing)!
        public void AddInt(int i)
        {
            arInts.Add(i);
        }

        public void ClearInts()
        {
            arInts.Clear();
        }

        public int Count => arInts.Count;

        IEnumerator IEnumerable.GetEnumerator() => arInts.GetEnumerator();
    }
}
