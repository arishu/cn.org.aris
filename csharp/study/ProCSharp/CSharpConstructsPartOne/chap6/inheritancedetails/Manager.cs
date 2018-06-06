using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap6.inheritancedetails
{
    class Manager : Employee
    {
        public int StockOptions { get; set; }


        public Manager(string fullName, int age, int empID,
            float currPay, string ssn, int numbOfOpts)
            :base(fullName, age, empID, currPay, ssn)
        {
            // This belongs with us
            StockOptions = numbOfOpts;
        }
    }
}
