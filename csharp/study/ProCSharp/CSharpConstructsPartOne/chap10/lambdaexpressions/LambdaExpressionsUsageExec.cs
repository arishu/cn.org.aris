using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap10.lambdaexpressions
{
    class LambdaExpressionsUsageExec : AChap10ExecObject
    {
        public override void Exec()
        {
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in LambdaExpressionsUsageExec.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
                throw;
            }
        }

        // Target for the Predicate<> delegate.
        static bool IsEvenNumber(int i)
        {
            // Is it an even number?
            return (i % 2) == 0;
        }

        /// <summary>
        /// Traditional Delegate Syntax
        /// </summary>
        private void TraditionalDelegateSyntax()
        {
            Console.WriteLine("=> Traditional Delegate Syntax: ");

            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            // Call FindAll() using traditional delegate syntax.
            Predicate<int> callback = IsEvenNumber;
            List<int> evenNumbers = list.FindAll(callback);

            Console.WriteLine("Here are your even numbers: ");
            foreach (int evenNumber in evenNumbers)
            {
                Console.WriteLine("{0}\t", evenNumber);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Anonymous Method Syntax
        /// </summary>
        private void AnonymousMethodSyntax()
        {
            Console.WriteLine("=> Anonymous Method Syntax: ");

            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            // Call FindAll() using anonymous method syntax.
            List<int> evenNumbers = list.FindAll
            (
                delegate(int i) 
                {
                    return (i % 2) == 0;
                }
            );

            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }

            Console.WriteLine();
        }

        
    }
}
