using CoreCSharpPrograming.chap6.inheritancedetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap6.polymorphic
{
    class PolymorphicExec : AChap6ExecObject
    {
        public override void Exec()
        {
            try
            {
                MethodOverrideUsage();

                PolymorpicWithNoInterface();

                PolymorphicWithInterface();

                MemberShadowing();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in PolymorphicExec.cs: {0}\n{1}",
                                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// Method Override Usage
        /// </summary>
        private void MethodOverrideUsage()
        {
            Console.WriteLine("=> Method Override Usage: ");

            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            chucky.GiveBonus(300);
            chucky.DisplayStatus();
            Console.WriteLine();

            SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
            fran.GiveBonus(200);
            fran.DisplayStatus();

            Console.WriteLine();
        }

        /// <summary>
        /// Polymorphic with no interface definition
        /// </summary>
        private void PolymorpicWithNoInterface()
        {
            Console.WriteLine("=> Polymorphic with no interface definition: ");

            HexagonWithInterface hex = new HexagonWithInterface("Beth");
            hex.Draw();

            Circle cir = new Circle("Cindy");
            cir.Draw();

            Console.WriteLine();
        }

        /// <summary>
        /// Polymorphic with interface definition
        /// </summary>
        private void PolymorphicWithInterface()
        {
            Console.WriteLine("=> Polymorphic with interface definition: ");

            ShapeWithInterface[] shapes = {
                new HexagonWithInterface(),
                new CircleWithInterface(),
                new HexagonWithInterface("Mick"),
                new CircleWithInterface("Beth"),
                new HexagonWithInterface("Linda")
            };

            foreach (ShapeWithInterface s in shapes)
            {
                s.Draw();
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Member Shadowing Usage
        /// </summary>
        private void MemberShadowing()
        {
            Console.WriteLine("=> Member Shadowing Usage: ");

            // This calls the Draw() method of the ThreeDCircleWithMemberShadowing
            ThreeDCircleWithMemberShadowing td = new ThreeDCircleWithMemberShadowing();
            td.Draw();

            // This calls the Draw() method of the parent
            ((CircleWithInterface)td).Draw();

            Console.WriteLine();
        }
    }
}
