using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreCSharpPrograming.chap10.sendingobjectstatenotifications
{
    class SendingObjectStateNotificationsExec : AChap10ExecObject
    {
        public override void Exec()
        {
            try
            {
                SendingObjectStateNotificationsUsage();

                MulticastingEnabling();

                RemovingTargetsFromDelegate();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs in SendingObjectStateNotificationsExec.cs: {0}\n{1}",
                    e.Message, e.StackTrace);
            }
        }

        // Callback function One
        static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n Message from Car Object: ");
            Console.WriteLine("-> {0}", msg);
            Console.WriteLine();
        }

        /// <summary>
        /// Delegate as event enablers
        /// </summary>
        private void SendingObjectStateNotificationsUsage()
        {
            Console.WriteLine("=> Delegate as event enablers: ");

            // First, make a Car object
            Car c1 = new Car("SlugBug", 100, 10);

            // Now, tell the car which method to call
            // when it wants to send up message
            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));

            // Speed up (this will trigger the events)
            Console.WriteLine("-> Speed Up: ");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            Console.WriteLine();
        }

        // Callback function Two
        static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine("-> {0}", msg.ToUpper());
        }

        /// <summary>
        /// Delegate object's Multicast functionality
        /// </summary>
        private void MulticastingEnabling()
        {
            Console.WriteLine("=> Delegate object's Multicast functionality: ");

            Car c1 = new Car("SlugBug", 100, 10);

            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent2));

            Console.WriteLine("-> Speed Up: ");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            Console.WriteLine();
        }

        /// <summary>
        /// Removing targets from Delegate's Invacation List
        /// </summary>
        private void RemovingTargetsFromDelegate()
        {
            Console.WriteLine("=> Removing targets from Delegate's Invacation List: ");

            Car c1 = new Car("SlugBug", 100, 10);
            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));

            Car.CarEngineHandler handler2 = new Car.CarEngineHandler(OnCarEngineEvent2);
            c1.RegisterWithCarEngine(handler2);

            Console.WriteLine("-> Speed Up: ");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            c1.UnRegisterWithCarEngine(handler2);

            Console.WriteLine("-> Speed Up: ");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            Console.WriteLine();
        }

        // 
        static void CallMeHere(string msg)
        {
            Console.WriteLine("=> Message from Car: {0}", msg);
        }

        /// <summary>
        /// Delegate Method Group Conversion
        /// </summary>
        private void DelegateMethodGroupConversion()
        {
            Console.WriteLine("=> Delegate Method Group Conversion: ");

            Car c1 = new Car();
            c1.RegisterWithCarEngine(CallMeHere);

            Console.WriteLine("-> Speed Up: ");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            c1.UnRegisterWithCarEngine(CallMeHere);

            Console.WriteLine("-> Speed Up: ");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            Console.WriteLine();
        }
    }
}
