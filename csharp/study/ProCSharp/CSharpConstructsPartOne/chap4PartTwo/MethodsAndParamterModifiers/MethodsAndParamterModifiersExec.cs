using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap4PartTwo.MethodsAndParamterModifiers
{
    class MethodsAndParamterModifiersExec : AMethodsAndParamterModifiersExecObject
    {
        public override void Exec()
        {
            DefaultByValuePassing();

            OutModifierUsage();

            RefModifierUsage();

            RefReturnUsage();

            ParamsModifierUsage();

            NamedAndOptionalArgumentsUsage();
        }

        private int Add(int x, int y)
        {
            int ans = x + y;
            x = 10000;
            y = 88888;
            return ans;
        }

        /// <summary>
        /// Default By value-Passing
        /// </summary>
        private void DefaultByValuePassing()
        {
            Console.WriteLine("=> Default By Value-Passing: ");

            int x = 9, y = 10;
            Console.WriteLine("Before Call: x: {0}, y: {1}", x, y);
            Console.WriteLine("Answer is {0}", Add(x, y));
            Console.WriteLine("After Call: x: {0}, y: {1}", x, y);

            Console.WriteLine();
        }

        private void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }

        /// <summary>
        /// Out Modifier Usage
        /// </summary>
        private void OutModifierUsage()
        {
            Console.WriteLine("=> Out Modifier Usage: ");

            int x = 9, y = 10;
            Console.WriteLine("Before Call: x: {0}, y: {1}", x, y);
            Add(x, y, out int ans);
            Console.WriteLine("Answer is {0}", ans);
            Console.WriteLine("After Call: x: {0}, y: {1}", x, y);

            Console.WriteLine();
        }

        // Swap two strings
        private void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }

        /// <summary>
        /// Ref Modifier Usage
        /// </summary>
        private void RefModifierUsage()
        {
            Console.WriteLine("=> Ref Modifier Usage: ");

            string str1 = "Flip";
            string str2 = "Flop";

            Console.WriteLine("Before: {0}, {1}", str1, str2);
            SwapStrings(ref str1, ref str2);
            Console.WriteLine("After: {0}, {1}", str1, str2);
            
            Console.WriteLine();
        }

        private ref string SampleRefReturn(string[] strArray, int position)
        {
            return ref strArray[position];
        }

        /// <summary>
        /// Ref Return Usage
        /// </summary>
        private void RefReturnUsage()
        {
            Console.WriteLine("=> Use Ref Return: ");

            string[] stringArray = { "one", "two", "three" };

            Console.WriteLine("Before: {0}, {1}, {2}", stringArray[0], stringArray[1], stringArray[2]);
            ref var refOutput = ref SampleRefReturn(stringArray, 1);
            refOutput = "new";
            Console.WriteLine("After: {0}, {1}, {2}", stringArray[0], stringArray[1], stringArray[2]);

            Console.WriteLine();
        }

        private double CalculateAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles", values.Length);

            double sum = 0;
            if (values.Length == 0)
                return sum;

            for (int i = 0; i < values.Length; i++)
                sum += values[i];

            return (sum / values.Length);
        }

        /// <summary>
        /// Params Modifier Usage
        /// </summary>
        private void ParamsModifierUsage()
        {
            Console.WriteLine("=> Params Modifier Usage: ");

            // Pass in a comma-delimited list of doubles
            double average;
            average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
            Console.WriteLine("Average of data is: {0}", average);

            // Pass in an array of doubles
            double[] data = { 4.0, 3.2, 5.7 };
            average = CalculateAverage(data);
            Console.WriteLine("Average of data is: {0}", average);

            // Pass in no arguments
            Console.WriteLine("Average of data is {0}", CalculateAverage());

            Console.WriteLine();
        }

        private void DisplayFancyMessageWithNamedArguments(ConsoleColor textColor, 
            ConsoleColor backgroundColor, string message)
        {
            // Store old colors to restore after message is printed
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldBackgroundColor = Console.BackgroundColor;

            // Set new colors to restore after message is printed
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);

            // Restore previous colors
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldBackgroundColor;
        }

        private void DisplayFancyMessageWithOptionalArguments(ConsoleColor textColor = ConsoleColor.Blue,
            ConsoleColor backgroundColor = ConsoleColor.White, string message = "Test Message")
        {
            // Store old colors to restore after message is printed
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldBackgroundColor = Console.BackgroundColor;

            // Set new colors to restore after message is printed
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);

            // Restore previous colors
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldBackgroundColor;
        }

        /// <summary>
        /// Named Arguments and Optional Arguments Usage
        /// </summary>
        private void NamedAndOptionalArgumentsUsage()
        {
            Console.WriteLine("=> Named Arguments Usage: ");

            // First Display Solution
            DisplayFancyMessageWithNamedArguments(message: "Wow, Very Fancy indeed!",
                textColor: ConsoleColor.DarkRed,
                backgroundColor: ConsoleColor.White);


            // Second Display Solution
            DisplayFancyMessageWithNamedArguments(backgroundColor: ConsoleColor.Green,
                message: "Second Display Solution",
                textColor: ConsoleColor.DarkBlue);

            // Optional Arguments Usage
            DisplayFancyMessageWithOptionalArguments(message: "Hello");

            Console.WriteLine();
        }


    }
}
