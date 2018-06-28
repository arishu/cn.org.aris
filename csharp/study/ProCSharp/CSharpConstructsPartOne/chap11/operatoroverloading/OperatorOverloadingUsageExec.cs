using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap11.operatoroverloading
{
    class OperatorOverloadingUsageExec : AChap11ExecObject
    {
        public override void Exec()
        {
            try
            {
                BinaryOperatorsOverloading();

                UnaryOperatorsOverloading();

                EqualityOperatorsOverloading();

                ComparisonOperatorsOverloading();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in OperatorOverloadingUsageExec.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// Binary Operators Overloading
        /// </summary>
        private void BinaryOperatorsOverloading()
        {
            Console.WriteLine("=> Binary Operators Overloading:");

            Point ptOne = new Point(100, 100);
            Point ptTwo = new Point(40, 40);
            Console.WriteLine("ptOne = {0}", ptOne);
            Console.WriteLine("ptTwo = {0}", ptTwo);

            // Add the points to make a bigger point 
            Console.WriteLine("ptOne + ptTwo: {0}", ptOne + ptTwo);
            // Subtract the points to make a smaller point
            Console.WriteLine("ptOne - ptTwo: {0}", ptOne - ptTwo);

            // Get a bigger Point
            Point biggerPoint = ptOne + 10;
            Console.WriteLine("biggerPoint = ptOne + 10 = {0}", biggerPoint);
            Console.WriteLine("10 + biggerPoint = {0}", 10 + biggerPoint);


            Point ptThree = new Point(90, 5);
            Console.WriteLine("ptThree = {0}", ptThree);
            Console.WriteLine("ptThree += ptTwo: {0}", ptThree += ptTwo);

            Point ptFour = new Point(0, 500);
            Console.WriteLine("ptFour = {0}", ptFour);
            Console.WriteLine("ptFour -= ptThree: {0}", ptFour -= ptThree);

            Console.WriteLine();
        }

        /// <summary>
        /// Unary Operators Overloading
        /// </summary>
        private void UnaryOperatorsOverloading()
        {
            Console.WriteLine("=> Unary Operators Overloading: ");

            // Applying the ++ and -- unary operator to a Point
            Point ptFive = new Point(1, 1);
            Console.WriteLine("++ptFive = {0}", ++ptFive);
            Console.WriteLine("--ptFive = {0}", --ptFive);

            Point ptSix = new Point(20, 20);
            Console.WriteLine("ptSix++ = {0}", ptSix++);
            Console.WriteLine("ptSix-- = {0}", ptSix--);

            Console.WriteLine();
        }

        /// <summary>
        /// Equality Operators Overloading
        /// </summary>
        private void EqualityOperatorsOverloading()
        {
            Console.WriteLine("=> Equality Operators Overloading: ");

            // Make use of the overloaded equality operators
            Point ptOne = new Point(100, 100);
            Point ptTwo = new Point(40, 40);
            Console.WriteLine("ptOne == ptTwo: {0}", ptOne == ptTwo);
            Console.WriteLine("ptOne != ptTwo: {0}", ptOne != ptTwo);

            Console.WriteLine();
        }

        /// <summary>
        /// Comparison Operators Overloading
        /// </summary>
        private void ComparisonOperatorsOverloading()
        {
            Console.WriteLine("=> Comparison Operators Overloading: ");

            Point ptOne = new Point(100, 100);
            Point ptTwo = new Point(40, 40);
            Console.WriteLine("ptOne < ptTwo: {0}", ptOne < ptTwo);
            Console.WriteLine("ptOne > ptTwo: {0}", ptOne > ptTwo);

            Console.WriteLine();
        }
    }
}
