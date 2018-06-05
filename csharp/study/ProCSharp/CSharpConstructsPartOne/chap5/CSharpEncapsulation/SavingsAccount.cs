using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap5.CSharpEncapsulation
{
    class SavingsAccount
    {
        private double currBalance = 0D;

        private static double currInterestRate = 0.04;

        public static double InterestRate { get => currInterestRate; set => currInterestRate = value; }
        public double CurrBalance { get => currBalance; set => currBalance = value; }

        public SavingsAccount() { }

        public SavingsAccount(double balance)
        {
            CurrBalance = balance;
        }
    }
}
