using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap6.classcastingrules
{
    class ClassCastRulesExec : AChap6ExecObject
    {
        public override void Exec()
        {
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in ClassCastRulesExec.cs: {0}\n{1}",
                                    e.Message, e.StackTrace);
            }
        }
    }
}
