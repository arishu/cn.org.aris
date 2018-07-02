using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap12.applylinqtoarrays
{
    class ApplyLINQToArraysExec : AChap12ExecObject
    {
        public override void Exec()
        {
            try
            {
                QueryOverStrings();

                QueryOverStringsWithExtensionMethods();

                QueryWithoutLINQ();

                AnotherQueryOverStrings();

                QueryOverInts();

                QueryWithIntsUsingImplicitTypedLocalVariable();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in ApplyLINQToArraysExec.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// Query using LINQ query string
        /// </summary>
        private void QueryOverStrings()
        {
            Console.WriteLine("=> Query using LINQ query string: ");

            // Assume we have an array of strings
            string[] currentVideoGames = { "Morrowwind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2"};

            // Build a query expression to find the items in the query
            // that have an embeded space
            IEnumerable<string> subset = from g in currentVideoGames
                                         where g.Contains(" ")
                                         orderby g
                                         select g;

            // Print out the results
            foreach (string s in subset)
            {
                Console.WriteLine("Item: {0}", s);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Query using extension method
        /// </summary>
        private void QueryOverStringsWithExtensionMethods()
        {
            Console.WriteLine("=> Query using extension method: ");

            // Assume we have an array of strings
            string[] currentVideoGames = { "Morrowwind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

            // Build a query expression to find the items in the array
            // that have an embedded space
            IEnumerable<string> subset = currentVideoGames
                .Where(g => g.Contains(" "))
                .OrderBy(g => g).Select(g => g);

            ReflectOverQueryResults(subset);

            // Print out the result
            foreach (string s in subset)
            {
                Console.WriteLine("Item: {0}", s);
            }


            Console.WriteLine();
        }

        /// <summary>
        /// Query without LINQ
        /// </summary>
        private void QueryWithoutLINQ()
        {
            Console.WriteLine("=> Query without LINQ: ");

            // Assume we have an array of strings
            string[] currentVideoGames = { "Morrowwind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

            // Array for holding result
            string[] gamesWithSpaces = new string[5];

            // Fill result array by filtering original array
            for (int i = 0; i < currentVideoGames.Length; i++)
            {
                if (currentVideoGames[i].Contains(" "))
                {
                    gamesWithSpaces[i] = currentVideoGames[i];
                }
            }

            // Sort the result array
            Array.Sort(gamesWithSpaces);

            // Print out the result
            foreach (string s in gamesWithSpaces)
            {
                if (s != null)
                {
                    Console.WriteLine("Item: {0}", s);
                }
            }

            Console.WriteLine();
        }

        static void ReflectOverQueryResults(object resultSet, string queryType = "Query Expressions")
        {
            Console.WriteLine($"***** Info about your query using {queryType} *****");
            Console.WriteLine("resultSet is of type: {0}", resultSet.GetType().Name);
            Console.WriteLine("resultSet location: {0}", resultSet.GetType().Assembly.GetName().Name);
        }

        /// <summary>
        /// 
        /// </summary>
        private static void AnotherQueryOverStrings()
        {
            Console.WriteLine("=> ");

            // Assume we have an array of strings
            string[] currentVideoGames = { "Morrowwind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

            IEnumerable<string> subset = from g in currentVideoGames where g.Contains(" ") orderby g select g;

            ReflectOverQueryResults(subset);

            foreach (string s in subset)
            {
                Console.WriteLine("Item: {0}", s);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// LINQ and Extension methods
        /// </summary>
        private void QueryOverInts()
        {
            Console.WriteLine("=> LINQ and Extension methods: ");

            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            IEnumerable<int> subset = from i in numbers where i < 10 select i;

            foreach (int i in subset)
            {
                Console.WriteLine("Item: {0}", i);
            }

            ReflectOverQueryResults(subset);

            Console.WriteLine();
        }

        /// <summary>
        /// Using Implicit Typed Local Variable
        /// </summary>
        private void QueryWithIntsUsingImplicitTypedLocalVariable()
        {
            Console.WriteLine("=> Using Implicit Typed Local Variable: ");

            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            // Using Implicit typed local variable
            var subset = from i in numbers where i < 10 select i;

            foreach (int i in subset)
            {
                Console.WriteLine("Item: {0}", i);
            }

            ReflectOverQueryResults(subset);

            Console.WriteLine();
        }

        private LINQAndDeferredExecution()
        {
            Console.WriteLine();

            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            var subset = from i in numbers where i < 10 select i;

            foreach (var i in subset)
            {
                Console.WriteLine("{0} < 10", i);
            }
            Console.WriteLine();


            numbers[0] = 4;


            foreach (var j in subset)
            {
                Console.WriteLine("{0} < 10", j);
            }
            Console.WriteLine();

            ReflectOverQueryResults(subset);

            Console.WriteLine();
        }
    }
}
