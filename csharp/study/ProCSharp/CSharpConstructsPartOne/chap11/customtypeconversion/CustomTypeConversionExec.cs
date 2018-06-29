using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap11.customtypeconversion
{
    class CustomTypeConversionExec : AChap11ExecObject
    {
        public override void Exec()
        {
            try
            {
                ExplicitCustomConvertions();

                ExplicitCustomConvertionFromIntegers();

                ImplicitConvertions();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in CustomTypeConversionExec.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// Custom Convertions
        /// </summary>
        private void ExplicitCustomConvertions()
        {
            Console.WriteLine("=> Custom Convertions: ");

            // Make a Rectangle
            Rectangle r = new Rectangle(15, 4);
            Console.WriteLine(r.ToString());
            r.Draw();

            Console.WriteLine();

            // Convert r into a Square
            // based on the height of the Rectangle
            Square s = (Square)r;
            Console.WriteLine(s.ToString());
            s.Draw();

            Console.WriteLine();
        }

        /// <summary>
        /// Custom Convert Usage
        /// </summary>
        private void ExplicitCustomConvertionFromIntegers()
        {
            Console.WriteLine("=> Custom Convert Usage: ");

            // Converting an int to a Square
            Square s2 = (Square)10;
            Console.WriteLine("s2 = {0}", s2);

            // Converting a Square to an int
            int side = (int)s2;
            Console.WriteLine("Side length of s2 = {0}", side);

            Console.WriteLine();
        }

        /// <summary>
        /// Implicit Convertions
        /// </summary>
        private void ImplicitConvertions()
        {
            Console.WriteLine("=> Implicit Convertions: ");

            // Implicit Convertion
            Square s = new Square { Length = 7 };
            Rectangle r = s;
            Console.WriteLine("Rectangle = {0}", r);

            // Explicit Convertion using implicit function
            Square s2 = new Square { Length = 3 };
            Rectangle r2 = (Rectangle)s2;
            Console.WriteLine("Rectangle = {0}", r2);

            Console.WriteLine();
        }
    }
}
