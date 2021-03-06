﻿using CoreCSharpPrograming.chap7.simplestexample;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap7.configexceptionstate
{
    class ConfigExceptionStateExec : AChapt7ExecObject
    {
        public override void Exec()
        {
            try
            {
                TargetSitePropertyUsage();

                StackTracePropertyUsage();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in ConfigExceptionStateExec.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        /// <summary>
        /// TargetSite Property Usage
        /// </summary>
        private void TargetSitePropertyUsage()
        {
            Console.WriteLine("=> TargetSite Property Usage: ");

            try
            {
                Console.WriteLine("Creating a car and stepping on it!");
                Car myCar = new Car("Zippy", 20);
                myCar.CrankTunes(true);

                for (int i = 0; i < 10; i++)
                    myCar.Accelerate(10);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n*** Error! ***");

                Console.WriteLine("Member name: {0}", e.TargetSite);

                // Get the class that declares this member
                Console.WriteLine("Class defining member: {0}", e.TargetSite.DeclaringType);

                Console.WriteLine("Member type: {0}", e.TargetSite.MemberType);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
            }

            Console.WriteLine("\n**** Out of exception logic ****");
            Console.WriteLine();
        }

        /// <summary>
        /// StackTrace Property Usage
        /// </summary>
        private void StackTracePropertyUsage()
        {
            Console.WriteLine("=> StackTrace Property Usage: ");

            try
            {
                Console.WriteLine("Creating a car and stepping on it!");
                Car myCar = new Car("Zippy", 20);
                myCar.CrankTunes(true);

                for (int i = 0; i < 10; i++)
                    myCar.Accelerate(10);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n*** Error! ***");

                Console.WriteLine("Member name: {0}", e.TargetSite);

                // Get the class that declares this member
                Console.WriteLine("Class defining member: {0}", e.TargetSite.DeclaringType);

                Console.WriteLine("Member type: {0}", e.TargetSite.MemberType);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
                Console.WriteLine("Stack: {0}", e.StackTrace);
            }

            Console.WriteLine("\n**** Out of exception logic ****");
            Console.WriteLine();
        }

        /// <summary>
        /// HelpLink Property Usage
        /// </summary>
        private void HelpLinkPropertyUsage()
        {
            Console.WriteLine("=> HelpLink Property Usage: ");

            try
            {
                Console.WriteLine("Creating a car and stepping on it!");
                Car myCar = new Car("Zippy", 20);
                myCar.CrankTunes(true);

                for (int i = 0; i < 10; i++)
                    myCar.Accelerate(10);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n*** Error! ***");

                Console.WriteLine("Member name: {0}", e.TargetSite);

                // Get the class that declares this member
                Console.WriteLine("Class defining member: {0}", e.TargetSite.DeclaringType);

                Console.WriteLine("Member type: {0}", e.TargetSite.MemberType);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
                Console.WriteLine("Stack: {0}", e.StackTrace);
                Console.WriteLine("Help Link: {0}", e.HelpLink);
            }

            Console.WriteLine("\n**** Out of exception logic ****");
            Console.WriteLine();
        }

        /// <summary>
        /// Data Property Usage
        /// </summary>
        private void DataPropertyUsage()
        {
            Console.WriteLine("=> Data Property Usage: ");

            try
            {
                Console.WriteLine("Creating a car and stepping on it!");
                Car myCar = new Car("Zippy", 20);
                myCar.CrankTunes(true);

                for (int i = 0; i < 10; i++)
                    myCar.Accelerate(10);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n*** Error! ***");

                Console.WriteLine("Member name: {0}", e.TargetSite);

                // Get the class that declares this member
                Console.WriteLine("Class defining member: {0}", e.TargetSite.DeclaringType);

                Console.WriteLine("Member type: {0}", e.TargetSite.MemberType);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
                Console.WriteLine("Stack: {0}", e.StackTrace);
                Console.WriteLine("Help Link: {0}", e.HelpLink);
                Console.WriteLine("\n-> Custom Data: ");
                foreach (DictionaryEntry entry in e.Data)
                {
                    Console.WriteLine("-> {0}: {1}", entry.Key, entry.Value);
                }
            }

            Console.WriteLine("\n**** Out of exception logic ****");
            Console.WriteLine();
        }
    }
}
