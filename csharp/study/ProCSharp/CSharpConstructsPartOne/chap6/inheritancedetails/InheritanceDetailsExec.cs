using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap6.inheritancedetails
{
    class InheritanceDetailsExec : AChap6ExecObject
    {
        public override void Exec()
        {
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in InheritanceDetailsExec.cs: {0}\n{1}",
                                    e.Message, e.StackTrace);
            }
        }

        private void BasicInheritanceDetails()
        {

        }
    }
}
