using CoreCSharpPrograming.chap8.definecustominterface;
using CoreCSharpPrograming.chap8.interfaceimplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap8.invokeinterfacemembers
{
    class InvokeInterfaceMembersExec : IConsoleExecObject
    {
        public void Exec()
        {
            try
            {
                InvokingInterfaceMembersUsage();

                ObtainingInterfaceReferencesUsingExplicitlyCast();

                ObtainingInterfaceReferencesUsingAsKeyword();

                ObtainingInterfaceReferencesUsingIsKeyword();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in InvokeInterfaceMembersExec.cs: {0}\n{1}",
                                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// Invoking Interface Members at object level
        /// </summary>
        private void InvokingInterfaceMembersUsage()
        {
            Console.WriteLine("=> Invoking Interface Members at object level: ");

            Hexagon hex = new Hexagon();
            Console.WriteLine("Points: {0}", hex.Points);

            Console.WriteLine();
        }

        /// <summary>
        /// Obtaining Interface References Using Explicitly Cast
        /// </summary>
        private void ObtainingInterfaceReferencesUsingExplicitlyCast()
        {
            Console.WriteLine("=> Obtaining Interface References Using Explicitly Cast: ");

            Circle c = new Circle("Lisa");
            IPointy itfPt = null;

            try
            {
                itfPt = (IPointy)c;
                Console.WriteLine(itfPt.Points);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Obtaining Interface References Using As Keyword
        /// </summary>
        private void ObtainingInterfaceReferencesUsingAsKeyword()
        {
            Console.WriteLine("=> Obtaining Interface References Using As Keyword:");

            Hexagon hex2 = new Hexagon("Peter");
            IPointy itfPt2 = hex2 as IPointy;

            if (itfPt2 != null)
                Console.WriteLine("Points: {0}", itfPt2.Points);
            else
                Console.WriteLine("OOPS! Not pointy...");
            Console.WriteLine();
        }

        /// <summary>
        /// Obtaining Interface References Using Is Keyword
        /// </summary>
        private void ObtainingInterfaceReferencesUsingIsKeyword()
        {
            Console.WriteLine("=> Obtaining Interface References Using Is Keyword:");

            Shape[] myShapes = {
                new Hexagon(),
                new Circle(),
                new Triangle("Joe"),
                new Circle("JoJo")
            };

            for (int i = 0; i < myShapes.Length; i++)
            {
                myShapes[i].Draw();

                // If current shape is IPointy, then assigns it to variable ip
                if (myShapes[i] is IPointy ip)
                {
                    Console.WriteLine("-> Point: {0}", ip.Points);
                }
                else
                {
                    Console.WriteLine("-> {0}\'s not pointy!", myShapes[i].PetName);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
