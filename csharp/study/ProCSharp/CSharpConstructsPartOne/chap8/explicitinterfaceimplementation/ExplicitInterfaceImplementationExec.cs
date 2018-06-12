using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap8.explicitinterfaceimplementation
{
    class ExplicitInterfaceImplementationExec : AChap8ExecObject
    {
        public override void Exec()
        {
            try
            {
                ExplicitInterfaceImplementation();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in ExplicitInterfaceImplementationExec.cs: {0}\n{1}",
                                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// Explicitly Interface Implementation
        /// </summary>
        private void ExplicitInterfaceImplementation()
        {
            Console.WriteLine("=> Explicitly Interface Implementation: ");

            OctagonWithExplicitBinding oct = new OctagonWithExplicitBinding();

            // We must use casting to access the Draw() method
            IDrawToForm iftForm = (IDrawToForm)oct;
            iftForm.Draw();

            ((IDrawToPrinter)oct).Draw();

            if (oct is IDrawToMemory dtm)
                dtm.Draw();

            Console.WriteLine();
        }
    }
}
