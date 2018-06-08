using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap6.inheritancedetails
{
    public class Manager : Employee
    {
        public int StockOptions { get; set; }


        public Manager(string fullName, int age, int empID,
            float currPay, string ssn, int numbOfOpts)
            :base(fullName, age, empID, currPay, ssn)
        {
            // This belongs with us
            StockOptions = numbOfOpts;
        }

        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOptions += r.Next(500);
        }

        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine("Number of Stock Options: {0}", StockOptions);
        }
    }
}
