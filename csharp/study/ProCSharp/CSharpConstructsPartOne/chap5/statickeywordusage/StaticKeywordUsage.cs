using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap5.statickeywordusage
{
    class StaticKeywordUsage : AChap5ExecObject
    {
        public override void Exec()
        {
            StaticFiledDataUsage();

            StaticMethodUsage();

            StaticConstructorUsage();

            StaticClassUsage();


        }

        /// <summary>
        /// Static Field Data usage
        /// </summary>
        private void StaticFiledDataUsage()
        {
            Console.WriteLine("=> Static Field Data Usage: ");

            // Create three Account, 
            // and each account has its own "currBalance"
            // but shares same "currInterestRate"
            SavingsAccount s1 = new SavingsAccount(50);
            SavingsAccount s2 = new SavingsAccount(100);
            SavingsAccount s3 = new SavingsAccount(10000.75);

            Console.WriteLine();
        }

        /// <summary>
        /// Static Method Usage
        /// </summary>
        private void StaticMethodUsage()
        {
            Console.WriteLine("=> Static Method Usage: ");

            SavingsAccount s1 = new SavingsAccount(50);
            SavingsAccount s2 = new SavingsAccount(100);

            // Print the current interest rate
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

            SavingsAccount s3 = new SavingsAccount(10000.75);
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
            Console.WriteLine();
        }

        /// <summary>
        /// Static Constructor Usage
        /// </summary>
        private void StaticConstructorUsage()
        {
            Console.WriteLine("=> Static Constructor Usage: ");

            SavingsAccount s1 = new SavingsAccount(50);
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

            // Try to change the interest rate via property
            SavingsAccount.SetInterestRate(0.08);

            SavingsAccount s2 = new SavingsAccount(100);
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

            Console.WriteLine();
        }

        /// <summary>
        /// Static Class Usage
        /// </summary>
        private void StaticClassUsage()
        {
            Console.WriteLine("=> Static Class Usage: ");

            TimeUtilClass.PrintDate();
            TimeUtilClass.PrintTime();

            // Compiler error! Can't create an instance of a static class
            //TimeUtilClass tu = new TimeUtilClass();

            Console.WriteLine();
        }

        /// <summary>
        /// Static Class With Static Import
        /// </summary>
        private void StaticClassWithStaticImport()
        {
            Console.WriteLine("=> Static Class With Static Import: ");

            TimeUtilClassWithStaticImport.PrintDate();
            TimeUtilClassWithStaticImport.PrintTime();

            Console.WriteLine();
        }
    }
}
