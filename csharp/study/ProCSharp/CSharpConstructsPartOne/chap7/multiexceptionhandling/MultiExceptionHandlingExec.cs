using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap7.multiexceptionhandling
{
    class MultiExceptionHandlingExec : AChapt7ExecObject
    {
        public override void Exec()
        {
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in MultiExceptionHandlingExec.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// Multi Exception Handling Usage
        /// </summary>
        private void MultiExceptionHandlingUsage()
        {
            Console.WriteLine("=> Multi Exception Handling Usage: ");

            MultiExceptionCar myCar = new MultiExceptionCar("Rusty", 90);

            try
            {
                // Trip Arg out of range exception.
                myCar.Accelerate(-10);
            }
            catch (SerializedCarIsDeadException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch
            {
                throw;
            }

            Console.WriteLine();
        }

        /// <summary>
        /// General Catch Usage
        /// </summary>
        private void GeneralCatchStatementsUsage()
        {
            Console.WriteLine("=> General Catch Usage: ");

            MultiExceptionCar myCar = new MultiExceptionCar("Rusty", 90);

            try
            {
                // Trip Arg out of range exception.
                myCar.Accelerate(-10);
            }
            catch (SerializedCarIsDeadException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Inner Exception Usage
        /// </summary>
        private void InnerExceptionUsage()
        {
            Console.WriteLine("=> Inner Exception Usage: ");

            MultiExceptionCar myCar = new MultiExceptionCar("Rusty", 90);

            try
            {
                myCar.Accelerate(90);
            }
            catch (SerializedCarIsDeadException e)
            {
                try
                {
                    FileStream fs = File
                    .OpenWrite(@"D:\workspace\github\cn.org.aris\csharp\study\ProCSharp\CSharpConstructsPartOne\chap7\multiexceptionhandling\carErrors.txt");
                    byte[] buffer = Encoding.UTF8.GetBytes(e.Message);
                    fs.Write(buffer, 0, buffer.Length);
                    fs.Close();
                }
                catch (Exception e2)
                {
                    // Throw an exception that records the new exception,
                    // as well as the message of the first exception.
                    throw new SerializedCarIsDeadException(e.Message, e2);
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch
            {
                throw;
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Finally Block Usage
        /// </summary>
        private void FinallyBlockUsage()
        {
            Console.WriteLine("=> Finally Block Usage: ");

            MultiExceptionCar myCar = new MultiExceptionCar("Rusty", 90);
            myCar.CrankTunes(true);

            try
            {
                // Trip Arg out of range exception.
                myCar.Accelerate(-10);
            }
            catch (SerializedCarIsDeadException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch
            {
                throw;
            }
            finally
            {
                // This will always occur. 
                // Whether Exception occurs or not.
                myCar.CrankTunes(false);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Exception Filter Usage
        /// </summary>
        private void ExceptionFilterUsage()
        {
            Console.WriteLine("=> Exception Filter Usage: ");

            MultiExceptionCar myCar = new MultiExceptionCar("Rusty", 90);
            myCar.CrankTunes(true);

            try
            {
                // Trip Arg out of range exception.
                myCar.Accelerate(90);
            }
            catch (SerializedCarIsDeadException e) when (e.ErrorTimeStamp.DayOfWeek != DayOfWeek.Friday)
            {
                // This new line will only print if the when clause eveluates to true
                Console.WriteLine("Catching car is dead");

                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch
            {
                throw;
            }

            Console.WriteLine();
        }
    }
}
