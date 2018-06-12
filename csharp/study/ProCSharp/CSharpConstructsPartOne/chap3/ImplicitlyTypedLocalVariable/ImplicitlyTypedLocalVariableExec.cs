using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap3.ImplicitlyTypedLocalVariable
{
    class ImplicitlyTypedLocalVariableExec : AChap3ExecObject
    {
        public override void Exec()
        {
            try
            {
                ExplicitTypedLocalVariableDeclaration();

                ImplicitTypedLocalVariableDeclaration();

                DeclareImplicitVars();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in ImplicitlyTypedLocalVariableExec.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// Explicitly typed local variables are declared as follows:
        ///     dataType variableName = initialValue;
        /// </summary>
        private void ExplicitTypedLocalVariableDeclaration()
        {
            Console.WriteLine("=> Explicitly typed local variables: ");
            int myInt = 0;
            bool myBool = true;
            string myString = "Time Machine";

            Console.WriteLine("myInt = {0}, myBool = {1}, myString = {2}", myInt, myBool, myString);

            Console.WriteLine();
        }
        
        /// <summary>
        /// Implicitly typed local variables are declared as follows:
        ///     var variableName = initialValue;
        /// </summary>
        private void ImplicitTypedLocalVariableDeclaration()
        {
            Console.WriteLine("=> Implicitly typed local variables: ");
            var myInt = 0;
            var myBool = true;
            var myString = "Time Machine";

            Console.WriteLine("myInt = {0}, myBool = {1}, myString = {2}", myInt, myBool, myString);

            Console.WriteLine();
        }

        /// <summary>
        /// Get the type of Implicitly typed local variables
        /// </summary>
        private void DeclareImplicitVars()
        {
            Console.WriteLine("=> Get the type of implicitly typed local variable: ");
            var myInt = 0;
            var myBool = true;
            var myString = "Time Machine";

            Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
            Console.WriteLine("myString is a: {0}", myString.GetType().Name);

            Console.WriteLine();
        }
    }
}
