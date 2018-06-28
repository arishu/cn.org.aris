using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap11.indexermethod
{
    class MyConsoleClass : IStringContainer
    {
        private List<string> myStrings = new List<string>();

        public string this[int index]
        {
            get => myStrings[index];
            set => myStrings.Insert(index, value);
        }
    }
}
