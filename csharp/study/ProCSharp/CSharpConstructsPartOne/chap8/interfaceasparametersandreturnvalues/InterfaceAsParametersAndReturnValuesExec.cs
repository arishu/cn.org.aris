using CoreCSharpPrograming.chap8.definecustominterface;
using CoreCSharpPrograming.chap8.interfaceimplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap8.interfaceasparametersandreturnvalues
{
    class InterfaceAsParametersAndReturnValuesExec : AChap8ExecObject
    {
        public override void Exec()
        {
            try
            {
                InterfaceAsParameters();

                InterfaceAsReturnValue();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in InterfaceAsParametersAndReturnValuesExec.cs: {0}\n{1}",
                                    e.Message, e.StackTrace);
            }
        }

        // draw anyone supporting IDraw3D
        private void DrawIn3D(IDraw3D itf3D)
        {
            Console.WriteLine("-> Drawing IDraw3D compatible type");
            itf3D.Draw3D();
        }

        /// <summary>
        /// Interface as Parameters
        /// </summary>
        private void InterfaceAsParameters()
        {
            Console.WriteLine("=> Interface as Parameters: ");

            Shape[] myShapes = {
                new Hexagon(),
                new Circle(),
                new Triangle("joe"),
                new Circle("Jojo")
            };

            for (int i = 0; i < myShapes.Length; i++)
            {
                myShapes[i].Draw();

                if (myShapes[i] is IDraw3D idr)
                    DrawIn3D(idr);
            }

            Console.WriteLine();
        }

        // This method return the first object in the array
        // that implements IPointy
        private IPointy FindFirstPointyShape(Shape[] shapes)
        {
            foreach (Shape s in shapes)
            {
                if (s is IPointy ip)
                    return ip;
            }
            return null;
        }

        /// <summary>
        /// Interface As Return Value
        /// </summary>
        private void InterfaceAsReturnValue()
        {
            Console.WriteLine("=> Interface As Return Value: ");

            Shape[] shapes = {
                new Hexagon(),
                new Circle(),
                new Triangle("Joe"),
                new Circle("JoJo")
            };

            IPointy firstPointyItem = FindFirstPointyShape(shapes);
            Console.WriteLine("The item has {0} points", firstPointyItem.Points);

            Console.WriteLine();
        }
    }
}
