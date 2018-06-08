using CoreCSharpPrograming.chap6.inheritancedetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap6.containmentdelegation
{
    class ContainmentDelegationExec : AChap6ExecObject
    {
        public override void Exec()
        {
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in ContainmentDelegationExec.cs: {0}\n{1}",
                                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// Containment And Delegation Usage
        /// </summary>
        private void ContainmentAndDelegationUsage()
        {
            Console.WriteLine("=> Containment And Delegation Usage: ");

            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            double cost = chucky.GetBenefitCost();

            Console.WriteLine("Manager's Benefit is {0}", cost);

            Console.WriteLine();
        }
    }
}
