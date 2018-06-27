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
                TraditionalDelegateSyntax();

                AnonymousMethodSyntax();

                LambdaExpressionSyntax();

                LambdaExpressionWithMultipleStatements();

                LambdaExpressionWithMultipleParameters();

                LambdaExpressionWithNoneParameter();

                LambdaExpressionForPreviousExample();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in LambdaExpressionsUsageExec.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
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

        /// <summary>
        /// Lambda Expression Syntax
        /// </summary>
        private void LambdaExpressionSyntax()
        {
            Console.WriteLine("=> Lambda Expression Syntax: ");

            // Make a list of integers
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44});

            // Now, use a C# lambda expression
            List<int> evenNumbers = list.FindAll(i => (i % 2) == 0);

            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.WriteLine("{0}\t", evenNumber);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Lambda Expression with Multiple Statements
        /// </summary>
        private void LambdaExpressionWithMultipleStatements()
        {
            Console.WriteLine("=> Lambda Expression with Multiple Statements: ");

            // Make a List of integers
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            // Now, Process each argument within a group of code statements
            List<int> evenNumbers = list.FindAll( (i) =>
            {
                Console.WriteLine("value of i is currently: {0}", i);
                bool isEven = ((i % 2) == 0);
                return isEven;
            });

            Console.WriteLine("Here are your even numbers: ");
            foreach (int evenNumber in evenNumbers)
            {
                Console.WriteLine("{0}\t", evenNumber);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Lambda Expression With Multiple Parameters
        /// </summary>
        private void LambdaExpressionWithMultipleParameters()
        {
            Console.WriteLine("=> Lambda Expression With Multiple Parameters: ");

            // Register with delegate as a lamda expression
            SimpleMath m = new SimpleMath();
            m.SetMathHandler((msg, result) =>
            {
                Console.WriteLine("Message: {0}, Result: {1}", msg, result);
            });

            // This will execute the lamda expression
            m.Add(10, 10);

            Console.WriteLine();
        }

        /// <summary>
        /// Lambda Expression With No Parameter
        /// </summary>
        private void LambdaExpressionWithNoneParameter()
        {
            Console.WriteLine("=> Lambda Expression With No Parameter: ");

            // Register with delegate as a lamda expression
            SimpleMath m = new SimpleMath();
            SimpleMath.VerySimpleDelegate d = new SimpleMath.VerySimpleDelegate(() => { return "Enjoy your string!"; });
            Console.WriteLine(d());

            Console.WriteLine();
        }

        /// <summary>
        /// Lambda Expression For Previous Example
        /// </summary>
        private void LambdaExpressionForPreviousExample()
        {
            Console.WriteLine("=> Lambda Expression For Previous Example: ");

            // Make a car as usual
            CarWithEventArgs c1 = new CarWithEventArgs("SlugBug", 100, 10);

            // Hook into events with lambdas
            c1.AboutToBlow += (sender, e) => { Console.WriteLine(e.msg); };
            c1.Exploded += (sender, e) => { Console.WriteLine(e.msg); };

            // Speed up(this will generate the events
            Console.WriteLine("-> Speed Up: ");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            Console.WriteLine();
        }
    }
}
