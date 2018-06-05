using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap5.CSharpEncapsulation
{
    class Account
    {
        public double Balance { get; set; }
        public string Owner { get; set; }

        // Details of Account
        public string Details
        {
            get
            {
                return "Owner: " + Owner + ", Balance: " + Balance;
            }
        }

        public Account(double balance, string owner)
        {
            Balance = balance;
            Owner = owner;
        }
    }
}
