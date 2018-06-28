using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap11.customtypeconversion
{
    class CustomTypeConversionExec : AChap11ExecObject
    {
        public override void Exec()
        {
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in CustomTypeConversionExec.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }
    }
}
