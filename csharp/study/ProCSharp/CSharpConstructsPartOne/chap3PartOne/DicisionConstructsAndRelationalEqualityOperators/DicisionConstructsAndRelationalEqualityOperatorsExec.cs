using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.DicisionConstructsAndRelationalEqualityOperators
{
    class DicisionConstructsAndRelationalEqualityOperatorsExec : ADicisionConstructsAndRelationalEqualityOperatorsExecObject
    {
        public override void Exec()
        {
            

        }

        /// <summary>
        /// Using Pattern Matching Switch Statement
        /// </summary>
        private void ExecutePatternMatchingSwitch()
        {
            Console.WriteLine("=> Pattern Matching Switch Clause: ");

            Console.WriteLine("1 [Integer (5)], 2 [String (\"Hi\")], 3 [Decimal (2.5)]");
            string userChoice = Console.ReadLine();
            object choice;

            // standard constant pattern switch statement
            switch (userChoice)
            {
                case "1":
                    choice = 5;
                    break;
                case "2":
                    choice = "Hi";
                    break;
                case "3":
                    choice = 2.5;
                    break;
                default:
                    choice = 5;
                    break;
            }

            // pattern matching switch statement
            switch (choice)
            {
                case int i:
                    Console.WriteLine("Your choice is an integer.");
                    break;
                case string s:
                    Console.WriteLine("Yout choice is a string.");
                    break;
                case decimal d:
                    Console.WriteLine("Yout choice is a decimal.");
                    break;
                default:
                    Console.WriteLine("Your choice is something else.");
                    break;
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Using Pattern Matching Switch Statement With When Clause
        /// </summary>
        private void ExecutePatternMatchingSwitchWithWhen()
        {
            Console.WriteLine("Using Pattern Matching Switch Statement With When Clause: ");

            Console.WriteLine("1 [C#], 2 [VB]");
            Console.Write("Please pick your language preference: ");
            object langChoice = Console.ReadLine();
            var choice = int.TryParse(langChoice.ToString(), out int c) ? c : langChoice;
            switch (choice)
            {
                case int i when i == 2:
                case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("VB: OOP, multithreading, and more!");
                    break;
                case int i when i == 1:
                case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }

            Console.WriteLine();
        }


    }
}
