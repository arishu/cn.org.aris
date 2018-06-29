using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MyExtensionMethods
{
    static class MyExtensions
    {
        public static void DisplayDefiningAssembly(this object obj)
        {
            Console.WriteLine("{0} lives here: => {1}\n", obj.GetType().Name,
                Assembly.GetAssembly(obj.GetType()).GetName().Name);
        }

        public static int ReverseDigits(this int i)
        {
            // Translate int into a string, and then
            // get all the characters
            char[] digits = i.ToString().ToCharArray();

            // Now Reverse items in the array
            Array.Reverse(digits);

            // Put back into string
            string newDigits = new string(digits);

            // Finally, return the modified string back as an int
            return int.Parse(newDigits);
        }


        public static void PrintDataAndBeep(this System.Collections.IEnumerable iterator)
        {
            foreach (var item in iterator)
            {
                Console.WriteLine(item);
                Console.Beep();
            }
        }
    }
}
