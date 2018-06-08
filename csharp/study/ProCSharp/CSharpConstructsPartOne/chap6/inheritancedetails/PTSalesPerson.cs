using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap6.inheritancedetails
{
    /// <summary>
    /// Sealed Class, means that the class can't be extended by other classes
    /// </summary>
    sealed class PTSalesPerson : SalesPerson
    {
        public string PhoneNum { get; set; }

        public PTSalesPerson(string fullName, int age, int empID,
            float currPay, string ssn, int numbOfSales, string phoneNum)
            :base(fullName, age, empID, currPay, ssn, numbOfSales)
        {
            PhoneNum = phoneNum;
        }

        // Compiler error! Can't override this method
        // because it was sealed
        //public override void GiveBonus(float amount)
        //{

        //}
    }
}
