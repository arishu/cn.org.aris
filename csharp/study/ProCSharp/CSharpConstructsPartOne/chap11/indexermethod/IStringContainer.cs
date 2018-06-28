using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap11.indexermethod
{
    interface IStringContainer
    {
        string this[int index] { get; set; }
    }
}
