using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap5.statickeywordusage
{
    class SavingsAccount
    {
        // Instance-level data
        public double currBalance;

        // Static point of data
        public static double currInterestRate = 0.04;

        // Static Constructor
        static SavingsAccount()
        {
            Console.WriteLine("In Static Ctor");
            currInterestRate = 0.06;
        }

        // Instance Constructor
        public SavingsAccount(double balance)
        {
            Console.WriteLine("In Instance Ctor");
            currBalance = balance;
        }

        // Static members to set interest rate
        public static void SetInterestRate(double newRate)
            => currInterestRate = newRate;

        // Static members to get interest rate
        public static double GetInterestRate()
        {
            return currInterestRate;
        }
    }
}
