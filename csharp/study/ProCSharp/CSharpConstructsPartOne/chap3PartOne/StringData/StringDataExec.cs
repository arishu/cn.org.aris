using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.StringData
{
    class StringDataExec : AStringDataExecObject
    {
        public override void Exec()
        {
            StringEqualitySpecifyingCompareRules();

            StringsAreImmutable();

            StringBuilderUsage();

            StringInterpolation();
        }

        /// <summary>
        /// Do String comparation with Compare Rules
        /// </summary>
        private void StringEqualitySpecifyingCompareRules()
        {
            Console.WriteLine("=> String equality (Case Insensitive:)");
            string s1 = "Hello";
            string s2 = "HELLO";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();

            // Default Comparison
            Console.WriteLine("Default rules: " +
                "s1={0}, s2={1}, s1.Equals(s2): {2}", s1, s2, s1.Equals(s2));

            // Compare ignoring case
            Console.WriteLine("Ignore Case: " +
                "s1.Equals(s2, StringComparison.OrdinalIgnoreCase): {0}", 
                s1.Equals(s2, StringComparison.OrdinalIgnoreCase));

            // Compare Using InvariantCulture and ignoring case
            Console.WriteLine("Ignore Case, Invariant Culture: s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase): {0}", 
                s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));

            // Demonstrate IndexOf method with cultureComparison
            Console.WriteLine();

            // IndexOf method using Default rule 
            Console.WriteLine("Default Rules: s1 = {0}, s2 = {1}, s1.IndexOf(\"E\"): {2}",
                s1, s2, s1.IndexOf("E"));

            // IndexOf method using StringComparison.OrdinalIgnoreCase rule
            Console.WriteLine("Ignore Case: s1.IndexOf(\"E\", StringComparison.OrdinalIgnoreCase): {0}",
                s1.IndexOf("E", StringComparison.OrdinalIgnoreCase));

            // IndexOf method using StringComparison.InvariantCultureIgnoreCase rule
            Console.WriteLine("Ignore Case: s1.IndexOf(\"E\", StringComparison.InvariantIgnoreCase: {0})",
                s1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));
        }

        /// <summary>
        /// We must keep in mind that String Objects in C# are immutable
        /// </summary>
        private void StringsAreImmutable()
        {
            Console.WriteLine("=> String are Inmutable: ");

            // Set initial string value.
            string s1 = "This is my string.";
            Console.WriteLine("s1 = {0}", s1);

            // Uppercase s1?
            string upperString = s1.ToUpper();
            Console.WriteLine("upperString = {0}", upperString);

            // Nope! s1 is in the same format!
            Console.WriteLine("s1 = {0}", s1);
        }

        /// <summary>
        /// StringBuilder Usage
        /// </summary>
        private void StringBuilderUsage()
        {
            Console.WriteLine("=> Using the StringBuilder:");

            StringBuilder sb = new StringBuilder("=> Fantastic Games: ");
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowind");
            sb.AppendLine("Deus Ex" + "2");
            sb.AppendLine("System Shock");

            Console.WriteLine(sb.ToString());

            sb.Replace("2", " Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.", sb.Length);
            Console.WriteLine();
        }

        /// <summary>
        /// String Interpolation
        /// </summary>
        private void StringInterpolation()
        {
            // Some local variable, we will plug into out larger string
            int age = 4;
            string name = "Aris";

            // Using curly bracket syntax
            string greeting = string.Format("Hello {0}, you are {1} years old.", name, age);
            Console.WriteLine("Greeting Message using backet syntax: \n\t{0}", greeting);

            // Using String Interpolation
            string greeting2 = $"Hello {name}, you are {age} years old.";
            Console.WriteLine("Greeting Message using string interpolation: \n\t{0}", greeting2);

            string greeting3 = $"Hello {name.ToUpper()}, you are {age} years old.";
            Console.WriteLine("Greeting Message using string interpolation: \n\t{0}", greeting3);
        }    
    }
}
