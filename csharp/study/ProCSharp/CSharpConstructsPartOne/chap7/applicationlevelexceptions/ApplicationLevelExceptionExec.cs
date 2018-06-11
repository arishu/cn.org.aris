using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap7.applicationlevelexceptions
{
    class ApplicationLevelExceptionExec : AChapt7ExecObject
    {
        public override void Exec()
        {
            try
            {
                CustomExceptionExampleOne();

                CustomExceptionExampleTwo();

                CustomExceptionExampleThird();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in ApplicationLevelExceptionExec.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// Custom Exception Example One
        /// </summary>
        private void CustomExceptionExampleOne()
        {
            Console.WriteLine("=> Custom Exception Example One: ");

            CustomExceptionCar myCar = new CustomExceptionCar("Rusty", 90);

            try
            {
                // Trip Exception
                myCar.Accelerate(50);
            }
            catch (CarIsDeadException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ErrorTimeStamp);
                Console.WriteLine(e.CauseOfError);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Custom Exception Example Two
        /// </summary>
        private void CustomExceptionExampleTwo()
        {
            Console.WriteLine("=> Custom Exception Example Two: ");

            SecondCustomExceptionCar myCar = new SecondCustomExceptionCar("Rusty", 90);

            try
            {
                // Trip Exception
                myCar.Accelerate(50);
            }
            catch (CarIsDeadSecondException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ErrorTimeStamp);
                Console.WriteLine(e.CauseOfError);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Custom Exception Example Third
        /// </summary>
        private void CustomExceptionExampleThird()
        {
            Console.WriteLine("=> Custom Exception Example Third: ");

            ThirdCustomExceptionCar myCar = new ThirdCustomExceptionCar("Rusty", 90);

            try
            {
                // Trip Exception
                myCar.Accelerate(50);
            }
            catch (CarIsDeadThirdException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ErrorTimeStamp);
                Console.WriteLine(e.CauseOfError);
                Console.WriteLine(e.InnerException);
            }

            Console.WriteLine();
        }
    }
}
